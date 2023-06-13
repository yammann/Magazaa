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
    public class StoreExpensesManager : IStoreExpensesService
    {
        private IStoreExpensesDal _storeExpenses;
        public StoreExpensesManager(IStoreExpensesDal storeExpenses) 
        {
         _storeExpenses= storeExpenses;
        }
        public void Add(StoreExpenses storeExpenses)
        {
            _storeExpenses.Add(storeExpenses);
        }

        public void Delete(StoreExpenses storeExpenses)
        {
            _storeExpenses.Delete(storeExpenses);
        }

        public List<StoreExpenses> GetAll()
        {
            return _storeExpenses.GetAll();
        }

        public List<StoreExpenses> GetByDate(DateTime startDate, DateTime enddate)
        {
            return _storeExpenses.GetAll(x => x.ExpensesDate >= startDate && x.ExpensesDate <= enddate);
        }

        public void Update(StoreExpenses storeExpenses)
        {
            _storeExpenses.Update(storeExpenses);
        }
    }
}
