using E_commerce_website.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_website.Server.Dtos.UsersDTO
{
    public class UpdateUserRequestDto
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string PhoneNumber { get; set; }
        [Required]
        public required string PasswordHash { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public UserRole Role { get; set; }
        [Required]
        public required string Address { get; set; }
        public int? SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscriptions? Subscriptions { get; set; }
    }
}
