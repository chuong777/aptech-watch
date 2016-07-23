using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Exception
{
    public class NotFoundWithIdEx : BaseException
    {
        public NotFoundWithIdEx(string entityName) : base("Could not found " + entityName + " with that id")
        {
        }
    }
}