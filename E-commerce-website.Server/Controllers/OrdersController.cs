using E_commerce_website.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Server.Controllers
{
    [Route("/api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _context.Orders.ToList();
            return Ok(orders);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id) 
        {
            var order = _context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
    }
}
