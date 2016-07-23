using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Utils
{
    public class Result<T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }

        public Result(bool isSuccess, string message, T data)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
            this.Data = data;
        }

        public Result(bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
    }
}