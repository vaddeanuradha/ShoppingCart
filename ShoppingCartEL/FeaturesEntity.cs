using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEL
{
    public class FeaturesEntity
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }
        public int CategoryId { get; set; }
    }
}
