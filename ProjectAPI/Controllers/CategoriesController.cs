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
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        [Route("get-pager")]
        public PagedContent<CategoryDTO> GetAllCategoriesPager(int pageNumber, int pageSize)
        {
            return _categoryService.GetAllCategoriesPager(pageNumber, pageSize);
        }
        [HttpGet]
        [Route("get-all")]
        public List<CategoryDTO> GetAllCategories()
        {
            return _categoryService.GetAllCategories();
        }
        [HttpGet]
        [Route("get-item/Id")]
        public CategoryDTO GetCategoryById(int categoryId)
        {
            return _categoryService.GetCategoryById(categoryId);
        }
        [HttpPost]
        [Route("add-item")]
        public CategoryDTO AddCategory([FromBody] CategoryDTO categoryDTO)
        {
            return _categoryService.AddCategory(categoryDTO);
        }
        [HttpPut]
        [Route("edit-item")]
        public CategoryDTO UpdateCategory(Category category)
        {
            return _categoryService.UpdateCategory(category);
        }
        [HttpDelete]
        [Route("delete-item/{Id}")]
        public bool DeleteCategory(int categoryId)
        {
            return _categoryService.DeleteCategory(categoryId);
        }
    }
}
