using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Contracts
{
    public interface IProductService
    {
        PagedContent<ProductsDTO> GetAllProductsPager(int pageNumber, int pageSize);
        List<ProductsDTO> GetAllProducts();
        ProductsDTO GetProductById(int productId);
        ProductsDTO AddProduct(ProductsDTO productsDTO);
        bool AddProductsBulk(List<Product> productsDTO);
        ProductsDTO UpdateProduct(ProductsDTO productsDTO);
        bool DeleteProduct(int productId);
    }
}
