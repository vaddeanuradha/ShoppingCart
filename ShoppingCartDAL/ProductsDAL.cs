using ShoppingCartEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDAL
{
    public class ProductsDAL
    {
        private SCADatabase _database;       
        public ProductsDAL()
        {
            _database = new SCADatabase();
        }
        public List<ProductEntity> GetProducts()
        {
            List<ProductEntity> products = new List<ProductEntity>();
            var productsData = _database.Products.ToList();
            return productsData.ConvertToProductEntityList();
        }
        public ProductEntity GetProductById(int id)
        {
            ProductEntity product = new ProductEntity();
            var productData = _database.Products.FirstOrDefault(d => d.Id == id);
            product = productData.ConvertToProductEntity();
            return product;
        }
        public List<ProductEntity> GetProductsByCategory(int id)
        {
            List<ProductEntity> products = new List<ProductEntity>();
            var data = _database.Category_Product_Mapping.Where(d => d.CategoryId == id).ToList();
            foreach(var record in data)
            {
                products.Add(record.Product.ConvertToProductEntity());
            }
            return products;
        }
    }
}
