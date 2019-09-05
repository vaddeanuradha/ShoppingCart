using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCartDAL;
using ShoppingCartEL;

namespace ShoppingCartBL
{
   
    public class ProductBL
    {
        private ProductsDAL _productsDAL;
        public ProductBL()
        {
            _productsDAL = new ProductsDAL();
        }
        public List<ProductEntity> GetProducts()
        {
            return _productsDAL.GetProducts();
        }
        public List<ProductEntity> GetProductsByCategoryId(int id)
        {
            return _productsDAL.GetProductsByCategory(id);
        }
        public ProductEntity GetProductById(int id)
        {
            return _productsDAL.GetProductById(id);
        }
    }
}
