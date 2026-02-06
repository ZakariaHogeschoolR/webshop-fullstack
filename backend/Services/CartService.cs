using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class CartService
    {
        private readonly GenericRepository<Cart> _repository;
        public CartService(GenericRepository<Cart> repository)
        {
            _repository = repository;
        }

        public async Task<List<Cart>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Cart> GetByIdService(int id)
        {
            var Cart = await _repository.GetByIdAsync(id);
            
            if (Cart == null)
            {
                throw new KeyNotFoundException();
            }
            
            return Cart;
        }

        public async Task CreateService(CartCreateDto dto)
        {
            var CartCreate = new Cart
            {
                Id = dto.Id,
                UserId = dto.UserId,
                CreatedAt = dto.CreatedAt,
            };
            await _repository.AddAsync(CartCreate);
        }

        public async Task UpdateService(int id, CartUpdateDto dto)
        {
            var CartUpdate = new Cart
            {
                Id = dto.Id,
                UserId = dto.UserId,
                CreatedAt = dto.CreatedAt,
            };
            await _repository.UpdateAsync(CartUpdate);
        }

        public async Task DeleteService(int id)
        {
            var Cart = await this.GetByIdService(id);
            await _repository.DeleteAsync(Cart);
        }
    }
}