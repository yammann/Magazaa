using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStoreService
    {
        void Add(Store store);
        void Delete(Store store);
        List<Store> GetAll();
        void Update(Store store);
        Store GetStoreById(int id);
        Store GetStoreByProductId(int productid);
    }
}
