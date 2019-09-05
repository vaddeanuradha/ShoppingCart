using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartWebApi.Models
{
    public class FeatureModel
    {
        public int Id { get; set; }
        public int CategoryId{ get; set; }
        public string FeatureName { get; set;}
    }
}