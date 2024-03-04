using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Models
{
    public enum UserRole
    {
        Vendor,
        User,
        Admin
    }

    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string PasswordHash { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public required UserRole Role { get; set; }
        public required string Address { get; set; }
        public int? SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public Subscriptions? Subscriptions { get; set; }
    }
}

