using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class CommentService : BaseService<Comment>
    {
        public CommentService() : base(new CommentDao())
        {
        }
    }
}