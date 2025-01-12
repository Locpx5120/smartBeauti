﻿using System;
using System.Collections.Generic;

namespace ProjectSWP391.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int PcategoryId { get; set; }
        public string PcategoryName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
