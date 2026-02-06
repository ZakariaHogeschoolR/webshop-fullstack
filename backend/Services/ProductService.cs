using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class ProductService
    {
        private readonly GenericRepository<Product> _repository;
        public ProductService(GenericRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product> GetByIdService(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            
            if (product == null)
            {
                throw new KeyNotFoundException();
            }
            
            return product;
        }

        public async Task CreateService(ProductCreateDto dto)
        {
            var productCreate = new Product
            {
                ProductName = dto.ProductName,
                Description = dto.Description,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity,
                IsDeleted = dto.IsDeleted, 
                CreatedAt = dto.CreatedAt
            };
            await _repository.AddAsync(productCreate);
        }

        public async Task UpdateService(int id, ProductUpdateDto dto)
        {
            var productUpdate = new Product
            {
                ProductName = dto.ProductName,
                Description = dto.Description,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity,
                IsDeleted = dto.IsDeleted, 
                CreatedAt = dto.CreatedAt
            };
            await _repository.UpdateAsync(productUpdate);
        }

        public async Task DeleteService(int id)
        {
            var product = await this.GetByIdService(id);
            await _repository.DeleteAsync(product);
        }
    }
}