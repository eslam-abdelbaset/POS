using DAL.Models;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Repositories
{
    public class WrapperRepository : IRepositoryWrapper
    {
        private MyDBContext _repoContext;
        private IRepositoryCustomers _customers;
        private IRepositoryCustomersType _customersTypes;
        private IRepositoryCategory _category;
        private IRepositoryProducts _products;

        public IRepositoryCustomers Customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = new CustomersRepository(_repoContext);
                }
                return _customers;
            }
        }
        public IRepositoryCustomersType CustomersTypes
        {
            get
            {
                if (_customersTypes == null)
                {
                    _customersTypes = new CustomersTypeRepository(_repoContext);
                }
                return _customersTypes;
            }
        }
        public IRepositoryCategory Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }
        public IRepositoryProducts Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductsRepository(_repoContext);
                }
                return _products;
            }
        }
        public WrapperRepository(MyDBContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
