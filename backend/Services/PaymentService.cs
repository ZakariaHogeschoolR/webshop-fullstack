using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class PaymentService
    {
        private readonly GenericRepository<Payment> _repository;
        public PaymentService(GenericRepository<Payment> repository)
        {
            _repository = repository;
        }

        public async Task<List<Payment>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Payment> GetByIdService(int id)
        {
            var Payment = await _repository.GetByIdAsync(x => x.Id == id);
            
            if (Payment == null)
            {
                throw new KeyNotFoundException();
            }
            
            return Payment;
        }

        public async Task CreateService(PaymentCreateDto dto)
        {
            var PaymentCreate = new Payment
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                Amount = dto.Amount, 
                PaymentMethod = dto.PaymentMethod, 
                PaymentStatus = dto.PaymentStatus,
                PaymentHash = dto.PaymentHash,
                CreatedAt = dto.CreatedAt
            };
            await _repository.AddAsync(PaymentCreate);
        }

        public async Task UpdateService(int id, PaymentUpdateDto dto)
        {
            var PaymentUpdate = new Payment
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                Amount = dto.Amount, 
                PaymentMethod = dto.PaymentMethod, 
                PaymentStatus = dto.PaymentStatus,
                PaymentHash = dto.PaymentHash,
                CreatedAt = dto.CreatedAt
            };
            await _repository.UpdateAsync(PaymentUpdate);
        }

        public async Task DeleteService(int id)
        {
            var Payment = await this.GetByIdService(id);
            await _repository.DeleteAsync(Payment);
        }
    }
}