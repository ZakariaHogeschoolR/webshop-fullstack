using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class OrderService
    {
        private readonly GenericRepository<Order> _repository;
        public OrderService(GenericRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<List<Order>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Order> GetByIdService(int id)
        {
            var Order = await _repository.GetByIdAsync(id);
            
            if (Order == null)
            {
                throw new KeyNotFoundException();
            }
            
            return Order;
        }

        public async Task CreateService(OrderCreateDto dto)
        {
            var OrderCreate = new Order
            {
                Id = dto.Id,
                UserId = dto.UserId,
                TotalAmount = dto.TotalAmount,
                Status = dto.Status,
                CreatedAt = dto.CreatedAt 
            };
            await _repository.AddAsync(OrderCreate);
        }

        public async Task UpdateService(int id, OrderUpdateDto dto)
        {
            var OrderUpdate = new Order
            {
                Id = dto.Id,
                UserId = dto.UserId,
                TotalAmount = dto.TotalAmount,
                Status = dto.Status,
                CreatedAt = dto.CreatedAt
            };
            await _repository.UpdateAsync(OrderUpdate);
        }

        public async Task DeleteService(int id)
        {
            var Order = await this.GetByIdService(id);
            await _repository.DeleteAsync(Order);
        }
    }
}