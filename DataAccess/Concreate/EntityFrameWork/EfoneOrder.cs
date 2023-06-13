using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.EntityFrameWork
{
    public class EfoneOrder:EfEntityRepositoryBase<oneOrder,StoreContext>,IOneOrderDal
    {
        public double[] GetFiyatlar(long orderid)
        {
            using (var Context = new StoreContext())
            {
                return Context.oneOrders.Where(x => x.OrderId == orderid).Select(x => x.FinalPrice).ToArray();


            }
        }

        public List<int> GetoneOrderId(long orderid)
        {
            using (var context = new StoreContext())
            {
                return context.oneOrders.Where(x => x.OrderId == orderid).Select(x => x.Id).ToList();
            }
        }

        public List<int> GetoneOrderProductId(long orderid)
        {
            using (var context = new StoreContext())
            {
                return context.oneOrders.Where(x => x.OrderId == orderid).Select(x => x.ProductId).ToList();
            }
        }

        public int GetoneOrderQuantitiByProductId(int productid, long orderid)
        {
            using (var context = new StoreContext())
            {
                return context.oneOrders.Where(x => x.ProductId == productid && x.OrderId == orderid).Select(x => x.Quantiti).SingleOrDefault();
            }
        }

    
    }
}
