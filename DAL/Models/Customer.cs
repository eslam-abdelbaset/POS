using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? BirthDate { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerTypeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual CustomersType CustomerType { get; set; }
    }
}
