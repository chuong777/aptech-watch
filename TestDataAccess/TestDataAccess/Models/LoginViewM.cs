using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Models
{
    public class LoginViewM
    {
        [Required(ErrorMessage = "Username can not be null")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password can not be null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}