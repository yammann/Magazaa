using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class StoreExpenses:IEntity
    {
        public int Id { get; set; }
        public decimal Amont { get;set; }
        public DateTime ExpensesDate { get; set; }
        public string Not { get; set; }
    }
}
