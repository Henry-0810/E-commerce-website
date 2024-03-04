using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_commerce_website.Server.Models;

namespace E_commerce_website.Server.Dtos.VendorsDTO
{
    public class CreateVendorRequestDto
    {
        [Required]
        public required string VendorName { get; set; }
        public string? VendorAddress { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public required Users Users { get; set; }
    }
}
