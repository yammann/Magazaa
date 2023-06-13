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
    public class IntOutStoreManager : IIntOutStoreService
    {
        private IIntOutStoreDal _intOutStoreDal;

        public IntOutStoreManager(IIntOutStoreDal intOutStore)
        {
            _intOutStoreDal = intOutStore;
        }

        public void Add(IntOutStore intOutStore)
        {
            _intOutStoreDal.Add(intOutStore);
        }

        public void Delete(IntOutStore intOutStore)
        {
            _intOutStoreDal.Delete(intOutStore);
        }

        public List<IntOutStore> GetAll()
        {
            return _intOutStoreDal.GetAll();
        }

        public List<IntOutStore> GetByBusiness(string business)
        {
            return _intOutStoreDal.GetAll(x=> x.Business == business);
        }

        public void Update(IntOutStore intOutStore)
        {
            _intOutStoreDal.Update(intOutStore);
        }
    }
}
