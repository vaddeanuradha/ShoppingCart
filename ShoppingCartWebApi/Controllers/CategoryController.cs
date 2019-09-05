using ShoppingCartWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCartWebApi.Controllers
{
    public class CategoryController : ApiController
    {
        public CategoryModel categoryModel;
        public CategoryController()
        {
            categoryModel = new CategoryModel();
        }
        [HttpGet]
        [Route("api/Category")]
        public List<CategoryModel> GetCategories()
        {
            return categoryModel.GetCategories();
        }
       
    }
}