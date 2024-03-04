using E_commerce_website.Server.Dtos.VendorsDTO;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Mappers
{
    public static class VendorMappers
    {
        public static Vendors ToVendorsFromCreateDTO(this CreateVendorRequestDto vendorDto)
        {
            return new Vendors
            {
                VendorName = vendorDto.VendorName,
                VendorAddress = vendorDto.VendorAddress,
                UserId = vendorDto.UserId,
                Users = vendorDto.Users,
            };
        }
    }
}
