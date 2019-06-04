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
    public class FidersController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public FidersController(ElectroApiContext context)
        {
            _context = context;
        }

        // GET: api/Fiders
        [HttpGet]
        public IEnumerable<Fider> GetFiders()
        {
            return _context.Fiders;
        }

        // GET: api/Fiders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFider([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fider = await _context.Fiders.FindAsync(id);

            if (fider == null)
            {
                return NotFound();
            }

            return Ok(fider);
        }

        // PUT: api/Fiders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFider([FromRoute] int id, [FromBody] Fider fider)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fider.Id)
            {
                return BadRequest();
            }

            _context.Entry(fider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiderExists(id))
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

        // POST: api/Fiders
        [HttpPost]
        public async Task<IActionResult> PostFider([FromBody] Fider fider)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Fiders.Add(fider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFider", new { id = fider.Id }, fider);
        }

        // DELETE: api/Fiders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFider([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fider = await _context.Fiders.FindAsync(id);
            if (fider == null)
            {
                return NotFound();
            }

            _context.Fiders.Remove(fider);
            await _context.SaveChangesAsync();

            return Ok(fider);
        }

        private bool FiderExists(int id)
        {
            return _context.Fiders.Any(e => e.Id == id);
        }
    }
}