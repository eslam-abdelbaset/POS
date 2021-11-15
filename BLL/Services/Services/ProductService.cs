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
    public class ProductService : ServiceBase, IProductService
    {
        public ProductService(IRepositoryWrapper _repoWrapper) : base(_repoWrapper) { }
        public ProductsDTO AddProduct(ProductsDTO productsDTO)
        {
            Product product = new Product
            {
                CategoryId = productsDTO.CategoryId,
                IsActive = productsDTO.IsActive,
                ProductCode = productsDTO.ProductCode,
                ProductDescription = productsDTO.ProductDescription,
                ProductImagePath = productsDTO.ProductImagePath,
                ProductName = productsDTO.ProductName,
                ProductPrice = productsDTO.ProductPrice
            };
            _repoWrapper.Products.Create(product);
            _repoWrapper.Save();
            return OMapper.Mapper.Map<ProductsDTO>(product);
        }

        public bool AddProductsBulk(List<Product> products)
        {
            //var products = OMapper.Mapper.Map<List<Product>>(productsDTO);
            _repoWrapper.Products.AddProductsBulk(products);
            _repoWrapper.Save();
            return true;
        }

        public bool DeleteProduct(int productId)
        {
            Product product = _repoWrapper.Products.FindByCondition(p => p.ProductId == productId).FirstOrDefault();
            _repoWrapper.Products.Delete(product);
            _repoWrapper.Save();
            return true;
        }

        public List<ProductsDTO> GetAllProducts()
        {
            var products = _repoWrapper.Products.FindAll();
            return OMapper.Mapper.Map<List<ProductsDTO>>(products);
        }

        public PagedContent<ProductsDTO> GetAllProductsPager(int pageNumber, int pageSize)
        {
            var products = _repoWrapper.Products.GetAllPaged(pageNumber, pageSize);
            return new PagedContent<ProductsDTO>
            {
                CurrentPage = products.CurrentPage,
                PageCount = products.PageCount,
                PageSize = products.PageSize,
                RowCount = products.RowCount,
                Results = OMapper.Mapper.Map<List<ProductsDTO>>(products.Results)
            };
        }

        public ProductsDTO GetProductById(int productId)
        {
            Product product = _repoWrapper.Products.FindByCondition(p => p.ProductId == productId).FirstOrDefault();
            return OMapper.Mapper.Map<ProductsDTO>(product);
        }

        public ProductsDTO UpdateProduct(ProductsDTO productsDTO)
        {
            Product product = _repoWrapper.Products.FindByCondition(p => p.ProductId == productsDTO.ProductId).FirstOrDefault();

            product.CategoryId = productsDTO.CategoryId;
            product.IsActive = productsDTO.IsActive;
            product.ProductCode = productsDTO.ProductCode;
            product.ProductDescription = productsDTO.ProductDescription;
            product.ProductImagePath = productsDTO.ProductImagePath;
            product.ProductName = productsDTO.ProductName;
            product.ProductPrice = productsDTO.ProductPrice;
            _repoWrapper.Products.Update(product);
            _repoWrapper.Save();
            return OMapper.Mapper.Map<ProductsDTO>(product);
        }
    }
}
