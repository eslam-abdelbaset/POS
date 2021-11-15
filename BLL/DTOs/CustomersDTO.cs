using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class CustomersDTO
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerTypeName { get; set; }
        public int CustomerTypeId { get; set; }
        public bool IsActive { get; set; }

    }
}
