using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Exception
{
    public abstract class BaseException : System.Exception
    {
        public string Statement { get; set; }

        protected BaseException(string message)
        {
            Statement = message;
        }

        public override string ToString()
        {
            return Statement;
        }
    }
}