using E_commerce_website.Server.Dtos.ProductsDTO;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Mappers
{
    public static class ProductMappers
    {
        public static Products ToProductsFromCreateDTO(this CreateProductRequestDto productsDto)
        {
            return new Products
            {
                ProductName = productsDto.ProductName,
                Description = productsDto.Description,
                Price = productsDto.Price,
                Category = productsDto.Category,
                VendorId = productsDto.VendorId,
                Vendors = productsDto.Vendors,
            };
        }
    }
}
