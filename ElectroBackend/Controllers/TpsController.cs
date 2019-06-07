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

    public class TpsController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public TpsController(ElectroApiContext context)
        {
            _context = context;
        }

        // GET: api/Tps
        [HttpGet]
        public IEnumerable<Tp> GetTps()
        {
            return _context.Tps;
        }

        // GET: api/Tps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tp = await _context.Tps.FindAsync(id);

            if (tp == null)
            {
                return NotFound();
            }

            return Ok(tp);
        }

        // PUT: api/Tps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTp([FromRoute] int id, [FromBody] Tp tp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tp.Id)
            {
                return BadRequest();
            }

            _context.Entry(tp).State = EntityState.Modified;
            _context.Entry(tp.Transformer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpExists(id))
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

        // POST: api/Tps
        [HttpPost]
        public async Task<IActionResult> PostTp([FromBody] Tp tp)
         {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tps.Add(tp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTp", new { id = tp.Id }, tp);
        }

        // DELETE: api/Tps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tp = await _context.Tps.FindAsync(id);
            if (tp == null)
            {
                return NotFound();
            }

            _context.Tps.Remove(tp);
            await _context.SaveChangesAsync();

            return Ok(tp);
        }

        private bool TpExists(int id)
        {
            return _context.Tps.Any(e => e.Id == id);
        }
    }
}