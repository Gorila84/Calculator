using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IProductRepository
    {
        void DeleteProduct(int productId);
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        Product GetProduct(int productId);
        IQueryable<Product> GetAllProducts();
    }
}
