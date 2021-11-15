using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public string ProductImagePath { get; set; }
        public int CategoryId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Category Category { get; set; }
    }
}
