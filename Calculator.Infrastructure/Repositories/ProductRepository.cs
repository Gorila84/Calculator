using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _db;

        public ProductRepository(Context db)
        {
            _db = db;
        }

        public int AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return product.Id;
        }

        public void DeleteProduct(int productId)
        {
            var product = _db.Products.FirstOrDefault(w => w.Id == productId);
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }

        }

        public IQueryable<Product> GetAllProducts()
        {
            var products = _db.Products;
            return products;
        }

        public Product GetProduct(int productId)
        {
            var product = _db.Products.FirstOrDefault(w => w.Id == productId);
            return product;
        }

        public int UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
