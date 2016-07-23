using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class BaseEntity
    {
        [Required, Key]
        public int Id { get; set; }
    }
}