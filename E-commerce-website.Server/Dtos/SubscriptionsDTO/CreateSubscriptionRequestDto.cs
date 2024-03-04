using System.ComponentModel.DataAnnotations;

namespace E_commerce_website.Server.Dtos.SubscriptionsDTO
{
    public class CreateSubscriptionRequestDto
    {
        [Required]
        public required string PlanName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
    }
}
