using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public abstract class BaseEntity
    {
        [Required, Key]
        public int Id { get; set; }
    }
}