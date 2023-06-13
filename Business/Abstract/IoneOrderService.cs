using Entities.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IoneOrderService
    {
        void Add(oneOrder oneOrder);
        void Delete(oneOrder oneOrder);
        List<oneOrder> GetAll();
        List<oneOrder> GetoneOrderbyOrderId(long orderId);
        void Update(oneOrder oneOrder);
        long OrderId();
        double[] GetFiyatlar(long orderid);
        List<int>GetoneOrderId(long orderid);
        List<int> GetoneOrderProductId(long orderid);
        int GetoneOrderQuantitiByProductId(int productid, long orderid);
        oneOrder GetonOrder(int productid, long orderid);
    }
}
