using Entities;
using Entities.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductsbyProductName(string productName);
        void Update(Product product);
        string[] GetProductname();
        Product GetProductName(string productName);
        Product GetProductById(int id);
    }
}
