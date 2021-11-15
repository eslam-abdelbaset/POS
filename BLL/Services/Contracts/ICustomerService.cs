using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Contracts
{
    public interface ICustomerService
    {
        PagedContent<CustomersDTO> GetAllCustomersPager(int pageNumber, int pageSize = 10);
        List<CustomersDTO> GetAllCustomers();
        CustomersDTO GetCustomerById(int customerId);
        CustomersDTO AddCustomer(CustomersDTO customer, string actiontype);
        CustomersDTO UpdateCustomer(Customer customer, string actiontype);
        bool DeleteCustomer(int customerId);
    }
}
