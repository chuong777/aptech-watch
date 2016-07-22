using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using TestDataAccess.Entity;
using TestDataAccess.Service;

namespace TestDataAccess.Utils
{
    public class C
    {
        public static MVCDbContext DbContext = new MVCDbContext();
        public static UserService UserService = new UserService();
        public static BookService BookService = new BookService();
        public static CategoryService CategoryService = new CategoryService();
        public static ViewService ViewService = new ViewService();
        public static LoveService LoveService = new LoveService();
        public static CartService CartService = new CartService();
        public static BookTagService BookTagService = new BookTagService();
        public static CommentService CommentService = new CommentService();
        public static AuthorService AuthorService = new AuthorService();
        public static SearchService SearchService = new SearchService();
        public static DataFormatter DataFormatter = new DataFormatter();

        public static bool IsListContainItem<T>(ICollection<T> list, T item) where T : BaseEntity
        {
            foreach (T i in list)
            {
                if (i.Id == item.Id) return true;
            }
            return false;
        }
    }
}