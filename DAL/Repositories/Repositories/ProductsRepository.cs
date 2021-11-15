using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Repositories
{
    public class ProductsRepository : RepositoryBase<Product>, IRepositoryProducts
    {
        public ProductsRepository(MyDBContext repositoryContext) : base(repositoryContext)
        {

        }
        public void AddProductsBulk(IEnumerable<Product> products)
        {
            RepositoryContext.Set<Product>().AddRange(products);
        }
    }
}
