using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStoreExpensesService
    {
        void Add(StoreExpenses storeExpenses);
        void Delete(StoreExpenses storeExpenses);
        List<StoreExpenses> GetAll();
        List<StoreExpenses> GetByDate(DateTime startDate, DateTime enddate);
        void Update(StoreExpenses storeExpenses);
    }
}
