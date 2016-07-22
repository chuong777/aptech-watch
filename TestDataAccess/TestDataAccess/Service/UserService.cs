using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Models;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class UserService
    {
        public Result<User> Add(User user)
        {
            if (C.DbContext.Users.Any(d=>d.UserName.Equals(user.UserName)) == false)
            {
                C.DbContext.Users.Add(user);
                C.DbContext.SaveChanges();
                return new Result<User>(true, "Your account has been created!", user);
            }
            return new Result<User>(false, "This user name is existed, please choose another one");
        }

        public User FindUserByUserNamePassword(string userName, string password)
        {
            //if (C.dbContext.Users.Any(d => d.userName.Equals(userName) && d.password.Equals(password)) == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            var q = (from a in C.DbContext.Users
                     where a.UserName == userName && a.Password == password
                     select a).SingleOrDefault();
            return q;
        }

        public User GetCurrentUser()
        {
            return HttpContext.Current.Session["user"] == null ? null : (User) HttpContext.Current.Session["user"];
        }

        public void SetCurrentUser(User user)
        {
            HttpContext.Current.Session["user"] = user;
        }

        public bool IsUserLogin()
        {
            return HttpContext.Current.Session["user"] != null;
        }

        public void DeleteCurrentUser()
        {
            HttpContext.Current.Session.Remove("user");
        }

    }
}