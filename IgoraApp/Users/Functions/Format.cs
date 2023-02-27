using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgoraApp.Users.Functions
{
    internal class Format
    {
        public static string NumberString(string text)
            => string.Concat(text.Where(c => char.IsNumber(c)));

        public static string MoneyString(string text)
            => string.Concat(text.Where(c => char.IsNumber(c) || c.Equals(',')));

        public static string LetterString(string text)
            => string.Concat(text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)));
    }
}
