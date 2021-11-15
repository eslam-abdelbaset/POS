using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Repositories
{
    public class CustomersRepository : RepositoryBase<Customer>, IRepositoryCustomers
    {
        public CustomersRepository(MyDBContext repositoryContext) : base(repositoryContext) { }
    }
}
