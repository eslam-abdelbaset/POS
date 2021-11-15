using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Repositories
{
    public class CustomersTypeRepository : RepositoryBase<CustomersType>, IRepositoryCustomersType
    {
        public CustomersTypeRepository(MyDBContext repositoryContext) : base(repositoryContext)
        { }
    }
}
