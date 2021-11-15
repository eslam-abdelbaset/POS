using BLL.AutoMapperConfig;
using BLL.DTOs;
using BLL.Services.Contracts;
using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services.Services
{
    public class CategoryService : ServiceBase, ICategoryService
    {
        public CategoryService(IRepositoryWrapper _repoWrapper) : base(_repoWrapper) { }

        public CategoryDTO AddCategory(CategoryDTO categoryDTO)
        {
            Category category = new Category
            {
                CategoryCode = categoryDTO.CategoryCode,
                CategoryDescription = categoryDTO.CategoryDescription,
                CategoryImagePath = categoryDTO.CategoryImagePath,
                CategoryName = categoryDTO.CategoryName,
                IsActive = categoryDTO.IsActive,
                ParentCategoryId = categoryDTO.ParentCategoryId
            };
            _repoWrapper.Category.Create(category);
            _repoWrapper.Save();
            return OMapper.Mapper.Map<CategoryDTO>(category);
        }

        public bool DeleteCategory(int CategoryId)
        {
            Category category = _repoWrapper.Category.FindByCondition(c => c.CategoryId == CategoryId).FirstOrDefault();
            _repoWrapper.Category.Delete(category);
            _repoWrapper.Save();
            return true;
        }

        public List<CategoryDTO> GetAllCategories()
        {
            var categories = _repoWrapper.Category.FindAll();
            return OMapper.Mapper.Map<List<CategoryDTO>>(categories);
        }

        public PagedContent<CategoryDTO> GetAllCategoriesPager(int pageNumber, int pageSize)
        {
            var categories = _repoWrapper.Category.GetAllPaged(pageNumber, pageSize);
            return new PagedContent<CategoryDTO>
            {
                CurrentPage = categories.CurrentPage,
                PageCount = categories.PageCount,
                PageSize = categories.PageSize,
                RowCount = categories.RowCount,
                Results = OMapper.Mapper.Map<List<CategoryDTO>>(categories.Results)
            };
        }

        public CategoryDTO GetCategoryById(int categoryId)
        {
            var category = _repoWrapper.Category.FindByCondition(c => c.CategoryId == categoryId).FirstOrDefault();
            return OMapper.Mapper.Map<CategoryDTO>(category);
        }

        public CategoryDTO UpdateCategory(Category category)
        {
            var _category = _repoWrapper.Category.FindByCondition(c => c.CategoryId == category.CategoryId).FirstOrDefault();
            if (_category == null)
            {
                return null;
            }

            _category.CategoryCode = category.CategoryCode;
            _category.CategoryDescription = category.CategoryDescription;
            _category.CategoryImagePath = category.CategoryImagePath;
            _category.CategoryName = category.CategoryName;
            _category.IsActive = category.IsActive;
            _category.ParentCategoryId = category.ParentCategoryId;
            _repoWrapper.Category.Update(_category);
            _repoWrapper.Save();
            return OMapper.Mapper.Map<CategoryDTO>(_category);
        }
    }
}
