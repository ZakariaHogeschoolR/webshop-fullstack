using System.ComponentModel.DataAnnotations;

namespace Webshop.DataTransferObject
{
    public class UserCreateDto
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Role { get; set;}
        
    }
}