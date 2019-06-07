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
    public class CountersController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public CountersController(ElectroApiContext context)
        {
            _context = context;
        }

        // GET: api/Counters
        [HttpGet]
        public IEnumerable<Counter> GetCounter()
        {
            return _context.Counter;
        }

        // GET: api/Counters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCounter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var counter = await _context.Counter.FindAsync(id);

            if (counter == null)
            {
                return NotFound();
            }

            return Ok(counter);
        }

        // PUT: api/Counters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCounter([FromRoute] int id, [FromBody] Counter counter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != counter.Id)
            {
                return BadRequest();
            }

            _context.Entry(counter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounterExists(id))
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

        // POST: api/Counters
        [HttpPost]
        public async Task<IActionResult> PostCounter([FromBody] Counter counter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Counter.Add(counter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCounter", new { id = counter.Id }, counter);
        }

        // DELETE: api/Counters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCounter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var counter = await _context.Counter.FindAsync(id);
            if (counter == null)
            {
                return NotFound();
            }

            _context.Counter.Remove(counter);
            await _context.SaveChangesAsync();

            return Ok(counter);
        }

        private bool CounterExists(int id)
        {
            return _context.Counter.Any(e => e.Id == id);
        }
    }
}