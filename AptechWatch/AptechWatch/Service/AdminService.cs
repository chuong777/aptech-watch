using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;
using AptechWatch.Models;
using AptechWatch.Utils;

namespace AptechWatch.Service
{
    public class AdminService : BaseService<Admin>
    {
        public AdminService() : base(new AdminDao())
        {

        }

        private Admin GetAdminByUsername(string username)
        {
            return this.FindAll().FirstOrDefault(x => x.Username == username);
        }

        public void Register(UserModel user)
        {
            if (GetAdminByUsername(user.Username) == null)
            {
                this.Insert(new Admin()
                {
                    Password = DataFormatter.EncryptPassword(user.Password),
                    Email = user.Email,
                    Realname = user.Realname,
                    Username = user.Username,
                    IsSuperAdmin = user.IsSuperAdmin
                });
            }
        }

        public bool Login(UserModel user)
        {
            var admin = GetAdminByUsername(user.Username);
            return admin != null && DataFormatter.EncryptPassword(user.Password) == admin.Password;
        }
        public bool Edit(UserModel user)
        {
            var admin = GetAdminByUsername(user.Username);
            if (admin == null) return false;
            admin.Password = DataFormatter.EncryptPassword(user.Password);
            admin.Email = user.Email;
            admin.Realname = user.Realname;
            admin.Username = user.Username;
            admin.IsSuperAdmin = user.IsSuperAdmin;
            this.Update(admin);
            return true;
        }
    }
}