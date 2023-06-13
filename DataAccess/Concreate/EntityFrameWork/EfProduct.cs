using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;

namespace DataAccess.Concreate.EntityFrameWork
{

    public class EfProduct : EfEntityRepositoryBase<Product, StoreContext>, IProductDal
    {
        public string[] GetProductname()
        {
            using (var Context = new StoreContext())
            {
                return Context.Products.Select(x => x.ProductName).ToArray();

            }
        }
    }
}
