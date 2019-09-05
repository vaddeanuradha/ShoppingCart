using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShoppingCartBL;

namespace ShoppingCartWebApi.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        private ProductBL _productBl;
        public ProductModel()
        {
            _productBl = new ProductBL();
        }
        public List<ProductModel> GetProducts()
        {
            return _productBl.GetProducts().ConvertFromProductEntityList();
        }
        public List<ProductModel> GetProductsByCategory(int id)
        {
            return _productBl.GetProductsByCategoryId(id).ConvertFromProductEntityList();
        }
        public ProductModel GetProductById(int id)
        {
            return _productBl.GetProductById(id).ConvertFromProductEntity();
        }

    }
}