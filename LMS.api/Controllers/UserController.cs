using LMS.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: get all users

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = new List<Users>();
            users = await _context.Users.ToListAsync();

            return new JsonResult(users);
        }

        //Get: get user by email
        [HttpGet("email")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u=>u.Email==email);
            return new JsonResult(user);
        }
    }
}
