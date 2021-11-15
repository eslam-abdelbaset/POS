using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Contracts
{
    public interface IRepositoryProducts : IRepositoryBase<Product>
    {
        void AddProductsBulk(IEnumerable<Product> products);
    }
}
