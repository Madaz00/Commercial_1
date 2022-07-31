using Commercial_1.Data;
using Commercial_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commercial_1.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ProductModel productModel = new ProductModel
            {
                ProductlList = new List<Product>()
            };



            ApplicationDbContext applicationDbContext = new ApplicationDbContext();

            var data = applicationDbContext.Products.ToList()

                ;

            foreach (var item in data)

            {

                productModel.ProductlList.Add(new Product

                {

                    ProductId = item.ProductId,

                    ProductName = item.ProductName,

                    Image = item.Image,

                    Price = item.Price,

                });

            }

            return View(productModel);
        }
    }
}
