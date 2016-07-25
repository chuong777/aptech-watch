using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;
using AptechWatch.Models;
using AptechWatch.Utils;

namespace AptechWatch.Service
{
    public class CustomerService : BaseService<Customer>
    {
        public CustomerService() : base(new CustomerDao())
        {
        }
        private Customer GetAdminByUsername(string username)
        {
            return this.FindAll().FirstOrDefault(x => x.UserName == username);
        }
        public bool Register(UserModel user)
        {
            if (GetAdminByUsername(user.Username) != null) return false;
            this.Insert(new Customer()
            {
                Password = DataFormatter.EncryptPassword(user.Password),
                Email = user.Email,
                RealName = user.Realname,
                UserName = user.Username,
                Address = user.Address,
                Phone = user.Phone
            });
            return true;
        }

        public bool Login(UserModel user)
        {
            var admin = GetAdminByUsername(user.Username);
            return admin != null && DataFormatter.EncryptPassword(user.Password) == admin.Password;
        }

        public bool Edit(UserModel user)
        {
            var customer = GetAdminByUsername(user.Username);
            if (customer == null) return false;
            customer.Password = DataFormatter.EncryptPassword(user.Password);
            customer.Email = user.Email;
            customer.RealName = user.Realname;
            customer.UserName = user.Username;
            customer.Address = user.Address;
            customer.Phone = user.Phone;
            this.Update(customer);
            return true;
        }
    }
}