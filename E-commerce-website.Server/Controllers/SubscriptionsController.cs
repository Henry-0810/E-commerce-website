using E_commerce_website.Server.Data;
using E_commerce_website.Server.Dtos.SubscriptionsDTO;
using E_commerce_website.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Server.Controllers
{
    [Route("api/subscriptions")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubscriptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var subscriptions = _context.Subscriptions.ToList();
            return Ok(subscriptions);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var subscription = _context.Subscriptions.Find(id);
            if (subscription == null)
            {
                return NotFound();
            }
            return Ok(subscription);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateSubscriptionRequestDto subscriptionDto)
        {
            var subscriptionModel = subscriptionDto.ToSubscriptionsFromCreateDTO();
            _context.Subscriptions.Add(subscriptionModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = subscriptionModel.SubscriptionID }, subscriptionModel);
        }
    }
}

