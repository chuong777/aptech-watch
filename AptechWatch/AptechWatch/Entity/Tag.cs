using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Tag : BaseEntity
    {
        public String Title { get; set; }
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