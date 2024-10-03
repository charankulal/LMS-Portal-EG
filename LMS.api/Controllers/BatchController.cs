using LMS.api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.api.Controllers
{

    [Authorize]
    [Route("api/batches")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public BatchController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Get all batches
        [HttpGet]
        public async Task<IActionResult> GetBatches()
        {
            var batches = new List<Batches>();
            batches = await _context.Batches.ToListAsync();

            return new JsonResult(batches);
        }


        // Get Batch by Id
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBatchById(int Id)
        {
            var batch = await _context.Batches.FindAsync(Id);
            return new JsonResult(batch);
        }

        // Create a new batch

    }
}
