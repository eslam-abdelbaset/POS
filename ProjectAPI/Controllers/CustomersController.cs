using BLL.DTOs;
using BLL.Services.Contracts;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Authorize]
    [EnableCors("CrosOriginPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomersController(ICustomerService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("get-pager")]
        public IActionResult GetAllCustomersPager(int pageNumber, int pageSize = 10)
        {
            return Ok(_service.GetAllCustomersPager(pageNumber, pageSize));
        }
        [HttpGet]
        [Route("get-all")]
        public List<CustomersDTO> GetAllCustomers()
        {
            return _service.GetAllCustomers();
        }
        [HttpGet]
        [Route("get-item/{Id}")]
        public CustomersDTO GetCustomerById(int customerId)
        {
            return _service.GetCustomerById(customerId);
        }
        [HttpPost]
        [Route("add-item")]
        public CustomersDTO AddCustomer([FromBody] CustomersDTO customer)
        {
            return _service.AddCustomer(customer, "Add");
        }
        [HttpPut]
        [Route("edit-item")]
        public CustomersDTO UpdateCustomer(Customer customer)
        {
            return _service.UpdateCustomer(customer, "Update");
        }
        // delete
        [HttpDelete]
        [Route("delete-item/{Id}")]
        public bool DeleteCustomer(int Id)
        {
            return _service.DeleteCustomer(Id);
        }
    }
}
