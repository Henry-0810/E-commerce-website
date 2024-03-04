using E_commerce_website.Server.Data;
using E_commerce_website.Server.Dtos.UsersDTO;
using E_commerce_website.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Server.Controllers
{
    [Route("/api/users")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequestDto userDto)
        {
            var userModel = userDto.ToUserFromCreateDTO();
            _context.Users.Add(userModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = userModel.UserId }, userModel);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateUserRequestDto updateDto)
        {
            var userModel = _context.Users.FirstOrDefault(x=> x.UserId == id);
            if (userModel == null)
            {
                return NotFound();
            }

            userModel.UserName = updateDto.UserName;
            userModel.Email = updateDto.Email;
            userModel.PhoneNumber = updateDto.PhoneNumber;
            userModel.PasswordHash = updateDto.PasswordHash;
            userModel.Role = updateDto.Role;
            userModel.Address = updateDto.Address;
            userModel.SubscriptionId = updateDto.SubscriptionId;
            userModel.Subscriptions = updateDto.Subscriptions;

            _context.SaveChanges();
            return Ok(userModel);
        }   
    }
}
