using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Contracts
{
    public interface IRepositoryWrapper
    {
        IRepositoryCustomers Customers { get; }
        IRepositoryCustomersType CustomersTypes { get; }
        IRepositoryCategory Category { get; }
        IRepositoryProducts Products { get; }
        void Save();
    }
}
