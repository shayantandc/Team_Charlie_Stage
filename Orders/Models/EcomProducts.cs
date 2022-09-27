﻿using System;
using System.Collections.Generic;

namespace Category.Models
{
    public partial class EcomProducts
    {
        public EcomProducts()
        {
            EcomOrders = new HashSet<EcomOrders>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public virtual EcomCategory Category { get; set; }
        public virtual ICollection<EcomOrders> EcomOrders { get; set; }
    }
}
