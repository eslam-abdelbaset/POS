using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CustomersType
    {
        public CustomersType()
        {
            Customers = new HashSet<Customer>();
        }

        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public string CustomerTypeDesciption { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
