using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class OrderItemService
    {
        private readonly GenericRepository<OrderItem> _repository;
        public OrderItemService(GenericRepository<OrderItem> repository)
        {
            _repository = repository;
        }

        public async Task<List<OrderItem>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<OrderItem> GetByIdService(int id)
        {
            var OrderItem = await _repository.GetByIdAsync(id);
            
            if (OrderItem == null)
            {
                throw new KeyNotFoundException();
            }
            
            return OrderItem;
        }

        public async Task CreateService(OrderItemCreateDto dto)
        {
            var OrderItemCreate = new OrderItem
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                ProductName = dto.ProductName, 
                UnitPrice = dto.UnitPrice, 
                Quantity = dto.Quantity 
            };
            await _repository.AddAsync(OrderItemCreate);
        }

        public async Task UpdateService(int id, OrderItemUpdateDto dto)
        {
            var OrderItemUpdate = new OrderItem
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                ProductName = dto.ProductName, 
                UnitPrice = dto.UnitPrice, 
                Quantity = dto.Quantity 
            };
            await _repository.UpdateAsync(OrderItemUpdate);
        }

        public async Task DeleteService(int id)
        {
            var OrderItem = await this.GetByIdService(id);
            await _repository.DeleteAsync(OrderItem);
        }
    }
}