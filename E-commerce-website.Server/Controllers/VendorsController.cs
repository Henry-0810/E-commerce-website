using E_commerce_website.Server.Data;
using E_commerce_website.Server.Dtos.VendorsDTO;
using E_commerce_website.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Server.Controllers
{
    [Route("/api/vendors")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var vendors = _context.Vendors.ToList();
            return Ok(vendors);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
        var vendor = _context.Vendors.Find(id);
        if (vendor == null)
        {
            return NotFound();
        }
        return Ok(vendor);
        }   

        [HttpPost]
        public IActionResult Create([FromBody] CreateVendorRequestDto vendorDto)
        {
            var vendorModel = vendorDto.ToVendorsFromCreateDTO();
            _context.Vendors.Add(vendorModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = vendorModel.VendorId }, vendorModel);
        }
}
}
