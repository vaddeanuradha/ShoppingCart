using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCartEL;
namespace ShoppingCartWebApi.Models
{
    public static class Mappings
    {
        public static ProductModel ConvertFromProductEntity(this ProductEntity productEntity)
        {
            ProductModel product = new ProductModel();
            product.Id = productEntity.Id;
            product.Categories = new List<CategoryModel>(productEntity.Categories.ConvertFromCategoryEntityList());
            product.Description = productEntity.Description;
            product.ImageUrl = productEntity.ImageUrl;
            product.IsAvailable = productEntity.IsAvailable;
            product.IsDeleted = productEntity.IsDeleted;
            product.Price = productEntity.Price;
            product.Name = productEntity.Name;
            product.Quantity = productEntity.Quantity;
            product.UpdatedDate = productEntity.UpdatedDate;
            product.CreatedDate = productEntity.CreatedDate;
            return product;
        }
        public static List<ProductModel> ConvertFromProductEntityList(this List<ProductEntity> list)
        {
            List<ProductModel> products = new List<ProductModel>();
            foreach(var obj in list)
            {
                products.Add(obj.ConvertFromProductEntity());
            }
            return products;
        }
        public static CategoryModel ConvertFromCategoryEntity(this CategoryEntity categoryEntity)
        {
            CategoryModel category = new CategoryModel()
            {
                Id = categoryEntity.Id,
                CategoryName = categoryEntity.CategoryName
            };
            category.FeaturesList = new List<FeatureModel>();
            if (categoryEntity.FeaturesList ==null)
            {
                return category;
            }
            foreach(var feature in categoryEntity.FeaturesList)
            {
                category.FeaturesList.Add(new FeatureModel(){ Id = feature.Id, CategoryId = feature.CategoryId, FeatureName = feature.FeatureName });
            }
            return category;
        }
        public static List<CategoryModel> ConvertFromCategoryEntityList(this List<CategoryEntity> list)
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            foreach(var obj in list)
            {
                categories.Add(obj.ConvertFromCategoryEntity());
            }
            return categories;
        }
    }
}