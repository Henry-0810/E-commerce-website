using E_commerce_website.Server.Dtos.SubscriptionsDTO;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Mappers
{
    public static class SubscriptionMappers
    {
        public static Subscriptions ToSubscriptionsFromCreateDTO(this CreateSubscriptionRequestDto subscriptionDto)
        {
            return new Subscriptions
            {
                PlanName = subscriptionDto.PlanName,
                Description = subscriptionDto.Description,
                Price = subscriptionDto.Price,
                Duration = subscriptionDto.Duration,
            };
        }
    }
}
