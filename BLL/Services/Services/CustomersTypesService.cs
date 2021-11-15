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
    public class CustomersTypesService : ServiceBase, ICustomersTypesService
    {
        public CustomersTypesService(IRepositoryWrapper _repoWrapper) : base(_repoWrapper) { }
        public CustomersTypesDTO AddCustomersType(CustomersTypesDTO CustomersTypesDTO)
        {
            CustomersType _customersTypes = new CustomersType
            {
                CustomerTypeName = CustomersTypesDTO.CustomerTypeName,
                CustomerTypeDesciption = CustomersTypesDTO.CustomerTypeDesciption
            };
            _repoWrapper.CustomersTypes.Create(_customersTypes);
            _repoWrapper.Save();
            var CustomerType = OMapper.Mapper.Map<CustomersTypesDTO>(_customersTypes);
            return CustomerType;
        }

        public bool DeleteCustomersType(int customerTypeId)
        {
            var customerType = _repoWrapper.CustomersTypes.FindByCondition(c => c.CustomerTypeId == customerTypeId).FirstOrDefault();
            _repoWrapper.CustomersTypes.Delete(customerType);
            _repoWrapper.Save();
            return true;
        }

        public List<CustomersTypesDTO> GetAllCustomersTypes()
        {
            var _customersTypes = _repoWrapper.CustomersTypes.FindAll();
            var cutomersTypesDTO = OMapper.Mapper.Map<List<CustomersTypesDTO>>(_customersTypes);
            return cutomersTypesDTO;
        }

        public PagedContent<CustomersTypesDTO> GetallCustomersTypesPager(int pageNumber = 1, int pageSize = 10)
        {
            var customerTypes = _repoWrapper.CustomersTypes.GetAllPaged(pageNumber, pageSize);
            return new PagedContent<CustomersTypesDTO>
            {
                CurrentPage = customerTypes.CurrentPage,
                PageCount = customerTypes.PageCount,
                PageSize = customerTypes.PageSize,
                Results = OMapper.Mapper.Map<List<CustomersTypesDTO>>(customerTypes.Results),
                RowCount = customerTypes.RowCount
            };
        }

        public CustomersTypesDTO GetCustomersTypeById(int customerTypeId)
        {
            var customerType = _repoWrapper.CustomersTypes.FindByCondition(c => c.CustomerTypeId == customerTypeId).FirstOrDefault();
            return OMapper.Mapper.Map<CustomersTypesDTO>(customerType);
        }

        public CustomersTypesDTO UpdateCustomersType(CustomersType CustomersTypesDTO)
        {
            var customerType = _repoWrapper.CustomersTypes.FindByCondition(c => c.CustomerTypeId == CustomersTypesDTO.CustomerTypeId).FirstOrDefault();
            if (customerType == null)
            {
                return null;
            }
            customerType.CustomerTypeName = CustomersTypesDTO.CustomerTypeName;
            customerType.CustomerTypeDesciption = CustomersTypesDTO.CustomerTypeDesciption;

            _repoWrapper.CustomersTypes.Update(customerType);
            _repoWrapper.Save();
            return OMapper.Mapper.Map<CustomersTypesDTO>(customerType);
        }
    }
}
