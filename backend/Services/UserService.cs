using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Webshop.Models;
using Webshop.DataTransferObject;
using System.Reflection.Metadata.Ecma335;
namespace Webshop.Services
{
    public class UserService
    {
        private readonly GenericRepository<User> _repository;
        public UserService(GenericRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<List<User>>  GetAllService()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<User> GetByIdService(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            
            if (user == null)
            {
                throw new KeyNotFoundException();
            }
            
            return user;
        }

        public async Task CreateService(UserCreateDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = dto.PasswordHash,
                FullName = $"{dto.FirstName} {dto.LastName}",
                IsDeleted = false,
                CreatedAt = dto.CreatedAt,
                Role = dto.Role

            };
            await _repository.AddAsync(user);
        }

        public async Task UpdateService(int id, UserUpdateDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = dto.PasswordHash,
                FullName = $"{dto.FirstName} {dto.LastName}",
                IsDeleted = false,
                CreatedAt = dto.CreatedAt,
                Role = dto.Role

            };
            await _repository.UpdateAsync(user);
        }

        public async Task DeleteService(int id)
        {
            var user = await this.GetByIdService(id);
            await _repository.DeleteAsync(user);
        }
    }
}