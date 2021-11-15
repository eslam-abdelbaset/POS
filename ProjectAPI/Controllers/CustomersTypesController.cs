using BLL.DTOs;
using BLL.Services.Services;
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
    public class CustomersTypesController : ControllerBase
    {
        private CustomersTypesService _customersTypesService;
        public CustomersTypesController(CustomersTypesService customersTypesService)
        {
            _customersTypesService = customersTypesService;
        }

        [HttpGet]
        [Route("get-pager")]
        public PagedContent<CustomersTypesDTO> GetAllCustomersTypesPager(int pageNumber, int pageSize)
        {
            return _customersTypesService.GetallCustomersTypesPager(pageNumber, pageSize);
        }
        [HttpGet]
        [Route("get-all")]
        public List<CustomersTypesDTO> GetAllCustomersTypes()
        {
            return _customersTypesService.GetAllCustomersTypes();
        }
        [HttpGet]
        [Route("get-item/Id")]
        public CustomersTypesDTO GetCustomerTypeById(int customerTypeId)
        {
            return _customersTypesService.GetCustomersTypeById(customerTypeId);
        }
        [HttpPost]
        [Route("add-item")]
        public CustomersTypesDTO AddCustomerType([FromBody] CustomersTypesDTO customersTypesDTO)
        {
            return _customersTypesService.AddCustomersType(customersTypesDTO);
        }
        [HttpPut]
        [Route("edit-item")]
        public CustomersTypesDTO UpdateCustomerType(CustomersType customersTypes)
        {
            return _customersTypesService.UpdateCustomersType(customersTypes);
        }
        [HttpDelete]
        [Route("delete-item/Id")]
        public bool DeleteCustomerType(int customerTypeId)
        {
            return _customersTypesService.DeleteCustomersType(customerTypeId);
        }

    }
}
