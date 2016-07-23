using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Brand : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string CountryCode { get; set; }

        public virtual ICollection<Watch> Watches { get; set; }

        public Brand()
        {
        }

        public Brand(string name, string countryCode)
        {
            Name = name;
            CountryCode = countryCode;
        }
    }
}