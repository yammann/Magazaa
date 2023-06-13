using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;

namespace DataAccess.Concreate.EntityFrameWork
{

    public class EfOrder : EfEntityRepositoryBase<Order, StoreContext>, IOrderDal
    {
        public double GetOrderPrice(long orderid)
        {
            using (var context = new StoreContext())
            {
                return context.Orders.Where(o => o.orderId == orderid).Select(o => o.OrderPrice).SingleOrDefault();
            }
        }
    }
}
