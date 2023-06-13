using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class oneOrderManager : IoneOrderService
    {
        private IOneOrderDal _oneOrderDal;

        public oneOrderManager(IOneOrderDal oneOrderDal)
        {
            _oneOrderDal = oneOrderDal;
        }

        public void Add(oneOrder oneOrder)
        {
           _oneOrderDal.Add(oneOrder);  
        }

        public void Delete(oneOrder oneOrder)
        {
            _oneOrderDal.Delete(oneOrder);
        }

        public List<oneOrder> GetAll()
        {
           return _oneOrderDal.GetAll();
        }

        public List<oneOrder> GetoneOrderbyOrderId(long orderId)
        {
            return _oneOrderDal.GetAll(oo => oo.OrderId == orderId);
        }

        public void Update(oneOrder oneOrder)
        {
            _oneOrderDal.Update(oneOrder);
        }
        public long OrderId()
        {
            Random r = new Random();
            long orderId = r.Next(1, 1000000);
            var result = _oneOrderDal.GetAll(oo => oo.OrderId == orderId);
            if (result.Count>0)
            {
                return OrderId();
            }
            else return orderId;
        }

        public double[] GetFiyatlar(long orderid)
        {
            return _oneOrderDal.GetFiyatlar(orderid);
        }

        public List<int> GetoneOrderId(long orderid)
        {
            return _oneOrderDal.GetoneOrderId(orderid);
        }

        public List<int> GetoneOrderProductId(long orderid)
        {
            return _oneOrderDal.GetoneOrderProductId(orderid);  
        }

        public int GetoneOrderQuantitiByProductId(int productid, long orderid)
        {
            return _oneOrderDal.GetoneOrderQuantitiByProductId(productid, orderid);
        }

        public oneOrder GetonOrder(int productid, long orderid)
        {
            return _oneOrderDal.GetAll(oO => oO.OrderId == orderid&&oO.ProductId==productid).SingleOrDefault();
        }
    }
}
