using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Handle
{
    internal class Handles
    {
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        public static string FormatPrice(decimal price){
            var culture = CultureInfo.GetCultureInfo("fr-FR");
            var formattedNumber = string.Format(culture, "{0:n}", price);
            return formattedNumber;
        }

        public static string getPreviousSession()
        {
            DateTime now = DateTime.Now;
            int resultMonth = 0;
            int resultYear = 0;
            if (now.Month == 1)
            {
                resultMonth = 12;
                resultYear = now.Year - 1;
            }
            else
            {
                resultMonth = now.Month - 1;
                resultYear = now.Year;
            }

            return resultMonth.ToString() + "-" + resultYear.ToString();

        }

      
    }
}
