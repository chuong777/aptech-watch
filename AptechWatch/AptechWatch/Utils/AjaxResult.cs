using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDataAccess.Utils
{
    public class AjaxResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Link { get; set; }

        public AjaxResult(bool success, string message, string link)
        {
            Success = success;
            Link = link;
            Message = message;
        }
    }
}