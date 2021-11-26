using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }
        [StringLength(250)]
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        [StringLength(250)]
        public string ProductImagePath { get; set; }
        public int CategoryId { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
    }
}
