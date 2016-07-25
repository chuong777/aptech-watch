using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace AptechWatch.Utils
{
    public class DataFormatter
    {
        public static float RoundTo2Decimal(float f)
        {
            return (float) Math.Round((decimal) f, 2, MidpointRounding.AwayFromZero);
        }

        public static string GetDateString(DateTime dateTime)
        {
            return dateTime.ToString("d/M/yyyy");
        }

        public static string GetDateTimeString(DateTime dateTime)
        {
            return dateTime.ToString("d/M/yyyy - H:m");
        }
        public static string EncryptPassword(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(password));

            //get hash result after compute it
            var result = md5.Hash;

            var strBuilder = new StringBuilder();
            foreach (var t in result)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(t.ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}