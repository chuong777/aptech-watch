using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Web;

namespace TestDataAccess.Utils
{
    public class DataFormatter
    {
        public float RoundTo2Decimal(float f)
        {
            return (float) Math.Round((Decimal) f, 2, MidpointRounding.AwayFromZero);
        }

        public string GetDateString(DateTime dateTime)
        {
            return dateTime.ToString("d/M/yyyy");
        }

        public string GetDateTimeString(DateTime dateTime)
        {
            return dateTime.ToString("d/M/yyyy - H:m");
        }
    }
}