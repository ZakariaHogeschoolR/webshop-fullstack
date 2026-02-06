using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class ShipmentService
    {
        private readonly GenericRepository<Shipment> _repository;
        public ShipmentService(GenericRepository<Shipment> repository)
        {
            _repository = repository;
        }

        public async Task<List<Shipment>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Shipment> GetByIdService(int id)
        {
            var shipment = await _repository.GetByIdAsync(x => x.Id == id);
            
            if (shipment == null)
            {
                throw new KeyNotFoundException();
            }
            
            return shipment;
        }

        public async Task CreateService(ShipmentCreateDto dto)
        {
            var shipmentCreate = new Shipment
            {
                OrderId = dto.OrderId,
                TrackingNumber = dto.TrackingNumber,
                ShipmentStatus = dto.ShipmentStatus,
                ShippedAt = dto.ShippedAt
            };
            await _repository.AddAsync(shipmentCreate);
        }

        public async Task UpdateService(int id, ShipmentUpdateDto dto)
        {
            var shipmentUpdate = new Shipment
            {
                OrderId = dto.OrderId,
                TrackingNumber = dto.TrackingNumber,
                ShipmentStatus = dto.ShipmentStatus,
                ShippedAt = dto.ShippedAt
            };
            await _repository.UpdateAsync(shipmentUpdate);
        }

        public async Task DeleteService(int id)
        {
            var shipment = await this.GetByIdService(id);
            await _repository.DeleteAsync(shipment);
        }
    }
}