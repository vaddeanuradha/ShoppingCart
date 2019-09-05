using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartDAL;
using ShoppingCartEL;
namespace ShoppingCartBL
{
    public class CategoryBL
    {
        private CategoryDAL _categoryDAL;
        public CategoryBL()
        {
            _categoryDAL = new CategoryDAL();
        }
        public List<CategoryEntity> GetCategories()
        {
            return _categoryDAL.GetCategories();
        }
  
    }
}
