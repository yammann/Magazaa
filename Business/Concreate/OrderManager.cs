using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetOrderbyOrderDate(DateTime orderDate)
        {
            return _orderDal.GetAll(o=>o.OrderDate== orderDate);
        }

        public double GetOrderPrice(long orderid)
        {
           return _orderDal.GetOrderPrice(orderid);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
     
    }
}
