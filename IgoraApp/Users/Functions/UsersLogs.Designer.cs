namespace IgoraApp.Users.Functions
{
    partial class UsersLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllLogs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetFilter = new System.Windows.Forms.Button();
            this.LoginsFilter = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortByDescending = new System.Windows.Forms.Button();
            this.SortByAscending = new System.Windows.Forms.Button();
            this.ClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllLogs
            // 
            this.AllLogs.AllowUserToAddRows = false;
            this.AllLogs.AllowUserToDeleteRows = false;
            this.AllLogs.AllowUserToResizeColumns = false;
            this.AllLogs.AllowUserToResizeRows = false;
            this.AllLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.AllLogs.Location = new System.Drawing.Point(0, 0);
            this.AllLogs.Name = "AllLogs";
            this.AllLogs.Size = new System.Drawing.Size(428, 379);
            this.AllLogs.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата/Время";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 113;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Удачно";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearFilter);
            this.groupBox1.Controls.Add(this.SetFilter);
            this.groupBox1.Controls.Add(this.LoginsFilter);
            this.groupBox1.Location = new System.Drawing.Point(434, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр по логину";
            // 
            // SetFilter
            // 
            this.SetFilter.Location = new System.Drawing.Point(55, 59);
            this.SetFilter.Name = "SetFilter";
            this.SetFilter.Size = new System.Drawing.Size(142, 27);
            this.SetFilter.TabIndex = 2;
            this.SetFilter.Text = "Фильтровать";
            this.SetFilter.UseVisualStyleBackColor = true;
            this.SetFilter.Click += new System.EventHandler(this.SetFilterClick);
            // 
            // LoginsFilter
            // 
            this.LoginsFilter.FormattingEnabled = true;
            this.LoginsFilter.Location = new System.Drawing.Point(37, 29);
            this.LoginsFilter.Name = "LoginsFilter";
            this.LoginsFilter.Size = new System.Drawing.Size(180, 24);
            this.LoginsFilter.TabIndex = 3;
            this.LoginsFilter.TextChanged += new System.EventHandler(this.LoginsFilterTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortByDescending);
            this.groupBox2.Controls.Add(this.SortByAscending);
            this.groupBox2.Location = new System.Drawing.Point(434, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 133);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировать по дате";
            // 
            // SortByDescending
            // 
            this.SortByDescending.Location = new System.Drawing.Point(37, 87);
            this.SortByDescending.Name = "SortByDescending";
            this.SortByDescending.Size = new System.Drawing.Size(190, 27);
            this.SortByDescending.TabIndex = 1;
            this.SortByDescending.Text = "По убыванию";
            this.SortByDescending.UseVisualStyleBackColor = true;
            this.SortByDescending.Click += new System.EventHandler(this.SortByDescendingClick);
            // 
            // SortByAscending
            // 
            this.SortByAscending.Location = new System.Drawing.Point(37, 46);
            this.SortByAscending.Name = "SortByAscending";
            this.SortByAscending.Size = new System.Drawing.Size(190, 27);
            this.SortByAscending.TabIndex = 0;
            this.SortByAscending.Text = "По возрастанию";
            this.SortByAscending.UseVisualStyleBackColor = true;
            this.SortByAscending.Click += new System.EventHandler(this.SortByAscendingClick);
            // 
            // ClearFilter
            // 
            this.ClearFilter.Location = new System.Drawing.Point(55, 92);
            this.ClearFilter.Name = "ClearFilter";
            this.ClearFilter.Size = new System.Drawing.Size(142, 27);
            this.ClearFilter.TabIndex = 4;
            this.ClearFilter.Text = "Очистить";
            this.ClearFilter.UseVisualStyleBackColor = true;
            this.ClearFilter.Click += new System.EventHandler(this.ClearFilterClick);
            // 
            // UsersLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AllLogs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersLogs";
            this.Text = "История входа пользователей";
            this.Load += new System.EventHandler(this.UsersLogsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AllLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetFilter;
        private System.Windows.Forms.ComboBox LoginsFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortByDescending;
        private System.Windows.Forms.Button SortByAscending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Button ClearFilter;
    }
}