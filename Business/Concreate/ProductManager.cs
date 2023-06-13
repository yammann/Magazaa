using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFrameWork;
using Entities;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
           _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public string[] GetProductname()
        {
           return _productDal.GetProductname();
        }

        public List<Product> GetProductsbyProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }
        public Product GetProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName==productName).SingleOrDefault();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public Product GetProductById(int id)
        {
            return _productDal.GetAll(p => p.Id == id).SingleOrDefault();
        }
    }
}
