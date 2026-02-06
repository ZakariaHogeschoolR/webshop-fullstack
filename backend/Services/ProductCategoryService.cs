using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class ProductCategoryService
    {
        private readonly GenericRepository<ProductCategory> _repository;
        private readonly ProductCategoryRepository _productCategoryRepository;
        public ProductCategoryService(GenericRepository<ProductCategory> repository, ProductCategoryRepository productCategoryRepository)
        {
            _repository = repository;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<List<ProductCategory>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ProductCategory> GetByIdService(int productId, int categoryId)
        {
            var productCategory = await _productCategoryRepository.GetByIdAsync(productId, categoryId);
            
            if (productCategory == null)
            {
                throw new KeyNotFoundException();
            }
            
            return productCategory;
        }

        public async Task CreateService(ProductCategoryCreateDto dto)
        {
            var productCategoryCreate = new ProductCategory
            {
                ProductId = dto.ProductId,
                CategoryId = dto.CategoryId,
            };
            await _repository.AddAsync(productCategoryCreate);
        }

        public async Task UpdateService(int id, ProductCategoryUpdateDto dto)
        {
            var productCategoryUpdate = new ProductCategory
            {
                ProductId = dto.ProductId,
                CategoryId = dto.CategoryId,
            };
            await _repository.UpdateAsync(productCategoryUpdate);
        }

        public async Task DeleteService(int productId, int categoryId)
        {
            var productCategory = await this.GetByIdService(productId, categoryId);
            await _repository.DeleteAsync(productCategory);
        }
    }
}