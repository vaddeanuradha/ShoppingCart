﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEL
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public List<FeaturesEntity> FeaturesList { get; set; }
    }
}
