using E_commerce_website.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_website.Server.Dtos.ProductsDTO
{
    public class CreateProductRequestDto
    {
        [Required]
        public required string ProductName { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Category { get; set; } = string.Empty;
        [Required]
        public int VendorId { get; set; }
        [ForeignKey("VendorId")]
        public required Vendors Vendors { get; set; }
    }
}
