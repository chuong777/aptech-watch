using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class OrderDetailService : BaseService<OrderDetail>
    {
        public OrderDetailService() : base(new OrderDetailDao())
        {
        }
    }
}