using BLL.AutoMapperConfig;
using BLL.DTOs;
using BLL.Services.Contracts;
using DAL.Models;
using DAL.Repositories.Contracts;
using DAL.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        public CustomerService(IRepositoryWrapper _repoWrapper)
            : base(_repoWrapper)
        {

        }
        public CustomersDTO AddCustomer(CustomersDTO customer, string actiontype)
        {
            Customer _customer = new Customer
            {
                CustomerName = customer.CustomerName,
                CustomerPhone = customer.CustomerPhone,
                BirthDate = customer.BirthDate,
                CustomerAddress = customer.CustomerAddress,
                CustomerDescription = customer.CustomerDescription,
                CustomerEmail = customer.CustomerEmail,
                CustomerTypeId = customer.CustomerTypeId,
                IsActive = customer.IsActive
            };

            _repoWrapper.Customers.Create(_customer);
            _repoWrapper.Save();

            var CustomersDTO = OMapper.Mapper.Map<CustomersDTO>(_customer);
            return CustomersDTO;
        }

        public bool DeleteCustomer(int customerId)
        {
            Customer _customer = _repoWrapper.Customers.FindByCondition(c => c.CustomerId == customerId).FirstOrDefault();
            _repoWrapper.Customers.Delete(_customer);
            _repoWrapper.Save();
            return true;
        }

        public List<CustomersDTO> GetAllCustomers()
        {
            var _customers = _repoWrapper.Customers.FindAll();

            var CustomersDTO = OMapper.Mapper.Map<List<CustomersDTO>>(_customers);
            return CustomersDTO;
        }

        public PagedContent<CustomersDTO> GetAllCustomersPager(int pageNumber, int pageSize = 10)
        {
            var customers = _repoWrapper.Customers.GetAllPaged(pageNumber, pageSize);
            return new PagedContent<CustomersDTO>
            {
                CurrentPage = customers.CurrentPage,
                PageCount = customers.PageCount,
                PageSize = customers.PageSize,
                RowCount = customers.RowCount,
                Results = OMapper.Mapper.Map<List<CustomersDTO>>(customers.Results)
            };
        }

        public CustomersDTO GetCustomerById(int customerId)
        {
            var _customer = _repoWrapper.Customers.FindByCondition(c => c.CustomerId == customerId).FirstOrDefault();
            var CustomersDTO = OMapper.Mapper.Map<CustomersDTO>(_customer);
            return CustomersDTO;
        }

        public CustomersDTO UpdateCustomer(Customer customer, string actiontype)
        {
            Customer _customer = _repoWrapper.Customers.FindByCondition(c => c.CustomerId == customer.CustomerId).FirstOrDefault();
            if (_customer == null)
            {
                return null;
            }

            _customer.CustomerName = customer.CustomerName;
            _customer.CustomerPhone = customer.CustomerPhone;
            _customer.BirthDate = customer.BirthDate;
            _customer.CustomerAddress = customer.CustomerAddress;
            _customer.CustomerDescription = customer.CustomerDescription;
            _customer.CustomerEmail = customer.CustomerEmail;
            _customer.CustomerTypeId = customer.CustomerTypeId;
            _customer.IsActive = customer.IsActive;

            _repoWrapper.Customers.Update(_customer);
            _repoWrapper.Save();

            var CustomersDTO = OMapper.Mapper.Map<CustomersDTO>(_customer);
            return CustomersDTO;
        }
    }
}
