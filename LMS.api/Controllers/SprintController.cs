﻿using LMS.api.Models;
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
            data.From_Day= DateOnly.FromDateTime(DateTime.Parse(data.From_Day.ToString()));
            data.To_Day = DateOnly.FromDateTime(DateTime.Parse(data.To_Day.ToString()));
            var sprints = new List<Sprints>();

            sprints = await _context.Sprints.ToListAsync();
            _context.Add(data);
            await _context.SaveChangesAsync();

            sprints = await _context.Sprints.ToListAsync();

            return new JsonResult(sprints);
        }


        // get all sprints by batch Id
        [HttpGet("view-sprints/{Id}")]
        public async Task<IActionResult> GetSprintsByBatchId(int Id)
        {
            var sprints = new List<Sprints>();
            sprints = await _context.Sprints.Where(b => b.BatchId == Id).ToListAsync();


            return new JsonResult(sprints);
        }

        // get a sprint by Id
        [HttpGet("view-sprint/{Id}")]
        public async Task<IActionResult> GetSprintsById(int Id)
        {
            var sprint = new List<Sprints>();
            sprint = await _context.Sprints.Where(b => b.Id == Id).ToListAsync();

            return new JsonResult(sprint);
        }

    }
}
