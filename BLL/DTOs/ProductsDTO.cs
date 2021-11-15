using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ProductsDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public string ProductImagePath { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }
    }
}
