using LMS.api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace LMS.api.Controllers
{
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
        [HttpPost("create-batch")]
        public async Task<IActionResult> CreateNewBatch([FromBody] Batches batchData)
        {
            _context.Add(batchData);
            await _context.SaveChangesAsync();
            return new JsonResult(new { id = batchData.Id });
        }

        // Delete the batch by Id
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBatchById(int Id)
        {
            var batch = await _context.Batches.FindAsync(Id);
            if (batch != null)
            {
                _context.Batches.Remove(batch);
            }
            else
            {
                return new JsonResult("Error: batch doesn't exist");
            }

            await _context.SaveChangesAsync();

            return new JsonResult("Deleted Successfully");
        }

        // Update the batch by id 
        [HttpPut("{Id}")]

        public async Task<IActionResult> UpdateBatchById(int Id, Batches batch)
        {
            batch.Id = Id;
            _context.Update(batch);
            await _context.SaveChangesAsync();
            var batches = await _context.Batches.ToListAsync();
            return new JsonResult(batches);
        }

        // Get all batches created by particular instructor
        [HttpGet("{instructorId}/batches")]
        public async Task<IActionResult> GetBatchesByInstructorId(int instructorId)
        {
            var batches = await _context.Batches.Where(b => b.InstructorId == instructorId).ToListAsync();
            return new JsonResult(batches);
        }

        
    }
}
