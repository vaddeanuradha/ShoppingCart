using ShoppingCartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ShoppingCartWebApi.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public List<FeatureModel> FeaturesList { get; set; }
        private CategoryBL categoryBL;
        public CategoryModel()
        {
            categoryBL = new CategoryBL();

        }
        public List<CategoryModel> GetCategories()
        {
            return categoryBL.GetCategories().ConvertFromCategoryEntityList();
        }
    }
}