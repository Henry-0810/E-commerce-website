using E_commerce_website.Server.Dtos.OrdersDTO;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Mappers
{
    public static class OrderMappers
    {
        public static Orders ToOrderFromCreateDTO(this CreateOrderRequestDto orderDto)
        {
            return new Orders
            {
                OrderDate = orderDto.OrderDate,
                OrderStatus = orderDto.OrderStatus,
                UserId = orderDto.UserId,
                Users = orderDto.Users,
            };
        }   
    }
}
