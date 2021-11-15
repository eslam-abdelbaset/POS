using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, IRepositoryCategory
    {
        public CategoryRepository(MyDBContext repositoryContext) : base(repositoryContext) { }
    }
}
