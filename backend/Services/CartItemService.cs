using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class CartItemService
    {
        private readonly GenericRepository<CartItem> _repository;
        public CartItemService(GenericRepository<CartItem> repository)
        {
            _repository = repository;
        }

        public async Task<List<CartItem>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CartItem> GetByIdService(int id)
        {
            var CartItem = await _repository.GetByIdAsync(x => x.Id == id);
            
            if (CartItem == null)
            {
                throw new KeyNotFoundException();
            }
            
            return CartItem;
        }

        public async Task CreateService(CartItemCreateDto dto)
        {
            var CartItemCreate = new CartItem
            {
                Id = dto.Id,
                CartId = dto.CartId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice, 
                PaymentHash = dto.PaymentHash 
            };
            await _repository.AddAsync(CartItemCreate);
        }

        public async Task UpdateService(int id, CartItemUpdateDto dto)
        {
            var CartItemUpdate = new CartItem
            {
                Id = dto.Id,
                CartId = dto.CartId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice, 
                PaymentHash = dto.PaymentHash
            };
            await _repository.UpdateAsync(CartItemUpdate);
        }

        public async Task DeleteService(int id)
        {
            var CartItem = await this.GetByIdService(id);
            await _repository.DeleteAsync(CartItem);
        }
    }
}