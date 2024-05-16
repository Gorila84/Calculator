using Calculator.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Web.Controllers
{
    public class ProductController : Controller
    {

        List<Product> products = new List<Product>();

        public ProductController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult ProductsList()
        {
           
            products.Add(new Product() { Id=1, Name="Sweter", Price=39.99M});
            products.Add(new Product() { Id = 1, Name = "Spodnie", Price = 69.99M });
            products.Add(new Product() { Id = 1, Name = "Buty", Price = 339.99M });
            return View(products);
        }

       
        public IActionResult Create(Product product)
        {
            //List<Product> products = new List<Product>();
            products.Add(product);
            return View(product);
            
        }

    }
}
