using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ElectroBackend.Models;

namespace ElectroBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkloadsController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public WorkloadsController(ElectroApiContext context)
        {
            _context = context;
        }

        // GET: api/Workloads
        [HttpGet]
        public IEnumerable<Workload> GetWorkloads()
        {
            return _context.Workloads;
        }

        // GET: api/Workloads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workload = await _context.Workloads.FindAsync(id);

            if (workload == null)
            {
                return NotFound();
            }

            return Ok(workload);
        }

        // PUT: api/Workloads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkload([FromRoute] int id, [FromBody] Workload workload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != workload.Id)
            {
                return BadRequest();
            }

            _context.Entry(workload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkloadExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Workloads
        [HttpPost]
        public async Task<IActionResult> PostWorkload([FromBody] Workload workload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Workloads.Add(workload);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkload", new { id = workload.Id }, workload);
        }

        // DELETE: api/Workloads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkload([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var workload = await _context.Workloads.FindAsync(id);
            if (workload == null)
            {
                return NotFound();
            }

            _context.Workloads.Remove(workload);
            await _context.SaveChangesAsync();

            return Ok(workload);
        }

        private bool WorkloadExists(int id)
        {
            return _context.Workloads.Any(e => e.Id == id);
        }
    }
}