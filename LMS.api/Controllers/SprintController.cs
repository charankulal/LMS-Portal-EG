using LMS.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.api.Controllers
{
    [ApiController]
    [Route("api/sprints")]
    public class SprintController : Controller
    {
        private readonly ApplicationDBContext _context;

        public SprintController(ApplicationDBContext context)
        {
            _context = context;
        }

        // create a new sprint
        [HttpPost("create")]
        public async Task<IActionResult> CreateSprint([FromBody] Sprints data)
        {
            var sprints = new List<Sprints>();

            sprints = await _context.Sprints.ToListAsync();
            _context.Add(data);
            await _context.SaveChangesAsync();

            sprints = await _context.Sprints.ToListAsync();

            return new JsonResult(sprints);
        }
    }
}
