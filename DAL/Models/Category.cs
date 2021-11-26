using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(255)]
        public string CategoryCode { get; set; }
        [StringLength(250)]
        public string CategoryDescription { get; set; }
        public int? ParentCategoryId { get; set; }
        [StringLength(150)]
        public string CategoryImagePath { get; set; }
        public bool? IsActive { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
