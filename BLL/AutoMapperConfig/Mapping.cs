using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.AutoMapperConfig
{
    public class Mapping : Profile
    {
        public Mapping()
        {

            //CreateMap<Lookup, LookupDTO>().ForMember(dest => dest.ValueTest, opt => opt.MapFrom(src => src.Value));
            CreateMap<Customer, CustomersDTO>().ForMember(dest => dest.CustomerTypeName, opt => opt.MapFrom(src => src.CustomerType.CustomerTypeName));
            CreateMap<CustomersType, CustomersTypesDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Product, ProductsDTO>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
            //.ForMember(dest => dest.LookId, opt => opt.MapFrom(src => src.CourseType.Id)).

        }
    }
}
