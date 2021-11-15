using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Contracts
{
    public interface ICustomersTypesService
    {
        PagedContent<CustomersTypesDTO> GetallCustomersTypesPager(int pageNumber = 1, int pageSize = 10);
        List<CustomersTypesDTO> GetAllCustomersTypes();
        CustomersTypesDTO GetCustomersTypeById(int customerTypeId);
        CustomersTypesDTO AddCustomersType(CustomersTypesDTO CustomersTypesDTO);
        CustomersTypesDTO UpdateCustomersType(CustomersType CustomersTypesDTO);
        bool DeleteCustomersType(int customerTypeId);

    }
}
