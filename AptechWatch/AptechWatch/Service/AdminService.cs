using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class AdminService : BaseService<Admin>
    {
        public AdminService() : base(new AdminDao())
        {
        }
    }
}