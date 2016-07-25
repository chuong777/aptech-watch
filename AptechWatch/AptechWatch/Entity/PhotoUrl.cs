using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class PhotoUrl : BaseEntity
    {
        [Required]
        public int Type { get; set; }
        [Required]
        public int GeneralId { get; set; }
        [Required]
        public String Url { get; set; }

        public PhotoUrl()
        {

        }

        public PhotoUrl(int type, int generalId, string url)
        {
            Type = type;
            GeneralId = generalId;
            Url = url;
        }
    }
}