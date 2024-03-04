using E_commerce_website.Server.Data;
using E_commerce_website.Server.Dtos.ProductsDTO;
using E_commerce_website.Server.Mappers;
using E_commerce_website.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductRequestDto productsDto)
        {
            var productModel = productsDto.ToProductsFromCreateDTO();
            _context.Products.Add(productModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = productModel.ProductId }, productModel);
        }
    }
}

