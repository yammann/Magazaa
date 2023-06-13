using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIntOutStoreService
    {
        void Add(IntOutStore intOutStore);
        void Delete(IntOutStore intOutStore);
        List<IntOutStore> GetAll();
        void Update(IntOutStore intOutStore);
        List<IntOutStore> GetByBusiness(string business);
    }
}
