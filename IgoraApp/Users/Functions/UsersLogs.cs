using IgoraApp.Data.DataBase;
using IgoraApp.Data.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    public partial class UsersLogs : Form
    {
        public UsersLogs()
        {
            InitializeComponent();
        }

        void FillLogs(List<Log> Logs)
        {
            AllLogs.Rows.Clear();
            LoginsFilter.Items.Clear();
            List<string> logins = new List<string>();
            foreach (var log in Logs)
            {
                AllLogs.Rows.Add(log.Login, log.AttemptTime, log.Authorized);
                logins.Add(log.Login);
            }
            LoginsFilter.Items.AddRange(logins.Distinct().ToArray());
        }

        private void UsersLogsLoad(object sender, EventArgs e) 
            => FillLogs(DataBase.GetDataBase().GetLogs());

        private void SetFilterClick(object sender, EventArgs e) 
            => FillLogs(DataBase.GetDataBase().GetLogs().Where(l => l.Login.Equals(LoginsFilter.Text)).ToList());

        private void SortByAscendingClick(object sender, EventArgs e) 
            => AllLogs.Sort(AllLogs.Columns[1], ListSortDirection.Ascending);

        private void SortByDescendingClick(object sender, EventArgs e) 
            => AllLogs.Sort(AllLogs.Columns[1], ListSortDirection.Descending);

        private void LoginsFilterTextChanged(object sender, EventArgs e) 
            => LoginsFilter.Text = "";

        private void ClearFilterClick(object sender, EventArgs e) 
            => FillLogs(DataBase.GetDataBase().GetLogs());
    }
}
