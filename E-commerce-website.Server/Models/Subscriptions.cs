using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Server.Models
{
    public class Subscriptions
    {
        [Key]
        public int SubscriptionID { get; set; }
        public required string PlanName { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public double Price { get; set; }
        public int Duration { get; set; }
    }
}
