using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class CommentService
    {
        public Comment Add(Comment comment)
        {
            C.DbContext.Comments.Add(comment);
            C.DbContext.SaveChanges();
            C.BookService.RateForBook(comment.Book, comment.Rate);
            return comment;
        }

        public List<Book> FindBookCommentedByUser(User user)
        {
            var q = (from a in C.DbContext.Comments
                     where a.UserId == user.Id
                     select a.Book).ToList();
            return q;
        }
    }
}