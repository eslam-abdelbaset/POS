using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
        public int? ParentCategoryId { get; set; }
        public string CategoryImagePath { get; set; }
        public bool? IsActive { get; set; }
    }
}
