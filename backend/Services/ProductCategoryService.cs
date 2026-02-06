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
        public ProductCategoryService(GenericRepository<ProductCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductCategory>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ProductCategory> GetByIdService(int id)
        {
            var productCategory = await _repository.GetByIdAsync(x => x.Id == id);
            
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

        public async Task DeleteService(int id)
        {
            var productCategory = await this.GetByIdService(id);
            await _repository.DeleteAsync(productCategory);
        }
    }
}