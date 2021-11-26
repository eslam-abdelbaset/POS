using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public int TypeId { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(CustomerType.Customers))]
        public virtual CustomerType Type { get; set; }
    }
}
