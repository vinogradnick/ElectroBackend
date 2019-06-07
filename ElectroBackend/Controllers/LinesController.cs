using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ElectroBackend.Models;
using Microsoft.AspNetCore.Authorization;

namespace ElectroBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class LinesController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public LinesController(ElectroApiContext context)
        {
            _context = context;
        }

        // GET: api/Lines
        [HttpGet]
        public IEnumerable<Line> GetLines()
        {
            return _context.Lines;
        }

        // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var line = await _context.Lines.FindAsync(id);

            if (line == null)
            {
                return NotFound();
            }

            return Ok(line);
        }

        // PUT: api/Lines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLine([FromRoute] int id, [FromBody] Line line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != line.Id)
            {
                return BadRequest();
            }

            _context.Entry(line).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineExists(id))
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

        // POST: api/Lines
        [HttpPost]
        public async Task<IActionResult> PostLine([FromBody] Line line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Lines.Add(line);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLine", new { id = line.Id }, line);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var line = await _context.Lines.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }

            _context.Lines.Remove(line);
            await _context.SaveChangesAsync();

            return Ok(line);
        }

        private bool LineExists(int id)
        {
            return _context.Lines.Any(e => e.Id == id);
        }
    }
}