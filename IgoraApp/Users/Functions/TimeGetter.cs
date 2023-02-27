using IgoraApp.Data.Entry;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IgoraApp.Users.Functions
{
    internal class TimeGetter
    {
        private static string SetTime(int time) => time < 10 ? "0" + time.ToString() : time.ToString();

        public static string GetTime()
        {
            Session.Time++;
            int Hour = Session.Time / 3600;
            int Minute = Session.Time / 60;
            int Second = Session.Time % 60;
            return $"{SetTime(Hour)} : {SetTime(Minute)} : {SetTime(Second)}";
        }
    }
}
