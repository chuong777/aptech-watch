using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace AptechWatch.Models
{
    public class UserModel : BaseModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [DisplayName("Username")]
        public string Username { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [DisplayName("Real name")]
        public string Realname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression("[0-9]{9, 11}")]
        public string Phone { get; set; }
        [Required]
        [MinLength(6)]
        [DisplayName("Confirm password")]
        public string ConfirmPassword { get; set; }
        public bool IsSuperAdmin { get; set; }
    }
}