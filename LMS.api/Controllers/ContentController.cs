using LMS.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ContentController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Create a new post
        [HttpPost("create-post")]
        public async Task<IActionResult> CreateNewBatch([FromBody] Contents data)
        {
            var posts = new List<Contents>();

            posts = await _context.Contents.ToListAsync();
            _context.Add(data);
            await _context.SaveChangesAsync();

            posts = await _context.Contents.ToListAsync();

            return new JsonResult(posts);
        }

        //Get Posts by the sprint Id
        [HttpGet("view-posts/{SprintId}")]
        public async Task<IActionResult>  GetPostsBySprintId(int SprintId)
        {
            var posts = new List<Contents>();
            posts= await _context.Contents.Where(c=>c.SprintId==SprintId).ToListAsync();

            return new JsonResult(posts);
        }
    }
}
