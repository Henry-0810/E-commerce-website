using E_commerce_website.Server.Dtos.UsersDTO;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Mappers
{
    public static class UserMappers
    {
        public static Users ToUserFromCreateDTO(this CreateUserRequestDto userDto)
        {
            return new Users
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                PhoneNumber = userDto.PhoneNumber,
                PasswordHash = userDto.PasswordHash,
                Address = userDto.Address,
                Role = userDto.Role,
                SubscriptionId = userDto.SubscriptionId,
            };
        }
    }
}
