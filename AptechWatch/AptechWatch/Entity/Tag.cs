using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public ICollection<WatchTag> WatchTags { get; set; }

        public Tag()
        {

        }

        public Tag(string title)
        {
            Title = title;
        }
    }
}