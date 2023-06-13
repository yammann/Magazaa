using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        void Delete(Order order);
        List<Order> GetAll();
        List<Order> GetOrderbyOrderDate(DateTime orderDate);
        void Update(Order order);
        double GetOrderPrice(long orderid);
    }
}
