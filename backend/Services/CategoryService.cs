using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class CategoryService
    {
        private readonly GenericRepository<Category> _repository;
        public CategoryService(GenericRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<Category>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdService(int id)
        {
            var Category = await _repository.GetByIdAsync(id);
            
            if (Category == null)
            {
                throw new KeyNotFoundException();
            }
            
            return Category;
        }

        public async Task CreateService(CategoryCreateDto dto)
        {
            var CategoryCreate = new Category
            {
                Id = dto.Id,
                CategoryName = dto.CategoryName,
                ParentCategoryId = dto.ParentCategoryId,
                Slug = dto.Slug,
                IsDeleted = false, 
                CreatedAt = dto.CreatedAt 
            };
            await _repository.AddAsync(CategoryCreate);
        }

        public async Task UpdateService(int id, CategoryUpdateDto dto)
        {
            var CategoryUpdate = new Category
            {
                Id = dto.Id,
                CategoryName = dto.CategoryName,
                ParentCategoryId = dto.ParentCategoryId,
                Slug = dto.Slug,
                IsDeleted = dto.IsDeleted, 
                CreatedAt = dto.CreatedAt 
            };
            await _repository.UpdateAsync(CategoryUpdate);
        }

        public async Task DeleteService(int id)
        {
            var Category = await this.GetByIdService(id);
            await _repository.DeleteAsync(Category);
        }
    }
}