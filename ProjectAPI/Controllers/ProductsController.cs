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
    //[Authorize]
    [EnableCors("CrosOriginPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("get-pager")]
        public PagedContent<ProductsDTO> GetAllProductsPager(int pageNumber, int pageSize = 10)
        {
            return _service.GetAllProductsPager(pageNumber, pageSize);
        }
        [HttpGet]
        [Route("get-all")]
        public List<ProductsDTO> GetAllProducts()
        {
            return _service.GetAllProducts();
        }
        [HttpGet]
        [Route("get-item/{Id}")]
        public ProductsDTO GetProductById(int productId)
        {
            return _service.GetProductById(productId);
        }
        [HttpPost]
        [Route("add-item")]
        public ProductsDTO AddProduct([FromBody] ProductsDTO product)
        {
            return _service.AddProduct(product);
        }
        [HttpPost]
        [Route("add-bulk")]
        public bool AddProductsBulk(List<Product> product)
        {
            return _service.AddProductsBulk(product);
        }
        [HttpPut]
        [Route("edit-item")]
        public ProductsDTO UpdateProduct(ProductsDTO product)
        {
            return _service.UpdateProduct(product);
        }
        // delete
        [HttpDelete]
        [Route("delete-item/{Id}")]
        public bool DeleteProduct(int Id)
        {
            return _service.DeleteProduct(Id);
        }
    }
}
