using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class StoreManager : IStoreService
    {
        private IStoreDal _storeDal;

        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public void Add(Store store)
        {
            _storeDal.Add(store);   
        }

        public void Delete(Store store)
        {
            _storeDal.Delete(store);    
        }

        public List<Store> GetAll()
        {
            return _storeDal.GetAll();
        }

        public Store GetStoreById(int id)
        {
            return _storeDal.GetAll(s=>s.Id==id).SingleOrDefault();
        }

        public Store GetStoreByProductId(int productid)
        {
            return _storeDal.GetAll(s => s.ProductId == productid).SingleOrDefault();
        }

        public void Update(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
