using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOneOrderDal : IEntityRepository<oneOrder>
    {
        double[] GetFiyatlar(long orderid);
        List<int> GetoneOrderId(long orderid);
        List<int> GetoneOrderProductId(long orderid);
        int GetoneOrderQuantitiByProductId(int productid, long orderid);
        
    }
}
