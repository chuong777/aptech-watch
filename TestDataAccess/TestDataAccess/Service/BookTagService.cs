using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class BookTagService
    {
        public List<BookTag> FindBookTagsByTag(Tag tag)
        {
            var q = (from a in C.DbContext.BookTags
                     where a.Id == tag.Id
                     select a).ToList();
            return q;
        }
    }
}