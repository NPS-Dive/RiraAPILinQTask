using Microsoft.AspNetCore.Mvc;
using Rira.Test.Code.Models;
using Rira.Test.Code.Services.Contracts;

namespace Rira.Test.Api.Controllers
    {
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
        {
        private readonly IProductService _productService;

        public ProductController ( IProductService productService )
            {
            _productService = productService;
            }


        [HttpGet]
        public List<Product> GetByCategory ( CategoryType category )
            {
            return _productService.GetByCategory(category);
            }

        [HttpGet]
        public Product MostExpensiveProduct ()
            {
            return _productService.MostExpensiveProduct();
            }

        [HttpGet]
        public double TotalPrice ()
            {
            return _productService.TotalPrice();
            }

        [HttpGet]
        public List<IGrouping<CategoryType, Product>> ProductGrouping ()
            {
            return _productService.ProductGrouping();
            }

        [HttpGet]
        public double MeanPrice ()
            {
            return _productService.MeanPrice();
            }
        }
    }
