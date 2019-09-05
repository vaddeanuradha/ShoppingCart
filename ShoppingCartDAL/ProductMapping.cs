using ShoppingCartEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDAL
{
    public static class Mapping
    { 
        public static ProductEntity ConvertToProductEntity(this Product product)
        {
            ProductEntity productEntity = new ProductEntity();

            productEntity.Id = product.Id;
               productEntity.Categories = new List<ShoppingCartEL.CategoryEntity>();
               foreach(var obj in product.Category_Product_Mapping)
               {
                productEntity.Categories.Add(new ShoppingCartEL.CategoryEntity()
                { Id = obj.Category.Id, CategoryName = obj.Category.CategoryName });
               }
               productEntity.ImageUrl = product.ImageUrl;
               productEntity.IsAvailable = product.IsAvailable.HasValue ? product.IsAvailable.Value : false;
               productEntity.Name = product.Name;
               productEntity.Price = product.Price.HasValue ? product.Price.Value : 0;
               productEntity.Quantity = product.Quantity.HasValue ? product.Quantity.Value : 0;
               productEntity.Description = product.Description;
            return productEntity;
        }
        public static List<ProductEntity> ConvertToProductEntityList(this List<Product> products)
        {
            List<ProductEntity> productEntityList = new List<ProductEntity>();
            foreach(var product in products)
            {
                productEntityList.Add(product.ConvertToProductEntity());
            }
            return productEntityList;
        }
        public static CategoryEntity ConvertToCategoryEntity(this Category category)
        {
            CategoryEntity categoryEntity = new CategoryEntity();
            categoryEntity.Id = category.Id;
            categoryEntity.CategoryName = category.CategoryName;
            categoryEntity.FeaturesList = new List<FeaturesEntity>();
            foreach(var feature in category.CategoryFeatures.ToList())
            {
                categoryEntity.FeaturesList.Add(new FeaturesEntity()
                { Id = feature.Id,
                  CategoryId = feature.CategoryId.HasValue?feature.CategoryId.Value:0,
                    FeatureName = feature.Name});

            }
            return categoryEntity;
        }
        public static List<CategoryEntity> ConvertToCategoryEntityList(this List<Category> list)
        {
            List<CategoryEntity> categoriesList = new List<CategoryEntity>();
            foreach(var category in list)
            {
                categoriesList.Add(category.ConvertToCategoryEntity());
            }
            return categoriesList;
        }
        
    }
}
