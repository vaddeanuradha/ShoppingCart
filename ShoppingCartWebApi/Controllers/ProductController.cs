using ShoppingCartWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCartWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private ProductModel _product;
        public ProductController()
        {
            _product = new ProductModel();
        }
        [HttpGet]
        public List<ProductModel> GetProducts()
        {
            return _product.GetProducts();
        }
        [HttpGet]
        public List<ProductModel> GetProductsByCategory(int id)
        {
            return _product.GetProductsByCategory(id);
        }
        [HttpGet]
        [Route("api/productById/{id}")]//attribute routing
        public ProductModel GetProductById(int id)
        {
            return _product.GetProductById(id);
        }
    }
}
