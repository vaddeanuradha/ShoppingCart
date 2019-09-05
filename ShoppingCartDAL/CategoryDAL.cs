using ShoppingCartEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDAL
{
    public class CategoryDAL
    {
        private SCADatabase _database;
        public CategoryDAL()
        {
           _database = new SCADatabase();
        }
        public List<CategoryEntity> GetCategories()
        {
            List<Category> categoriesList = new List<Category>();
            var data = _database.Categories.ToList();
            return data.ConvertToCategoryEntityList();

        }
       
       

    }
}
