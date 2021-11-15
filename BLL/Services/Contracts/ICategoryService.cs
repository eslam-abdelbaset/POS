using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Contracts
{
    public interface ICategoryService
    {
        PagedContent<CategoryDTO> GetAllCategoriesPager(int pageNumber, int pageSize);
        List<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int categoryId);
        CategoryDTO AddCategory(CategoryDTO categoryDTO);
        CategoryDTO UpdateCategory(Category category);
        bool DeleteCategory(int CategoryId);

    }
}
