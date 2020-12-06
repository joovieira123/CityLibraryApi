using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CityLibraryApi.Models;

namespace CityLibraryApi.Controllers
{
    [Route("api/Readers")]
    [ApiController]
    public class ReadersController : ControllerBase
    {
        private readonly ReaderContext _context;

        public ReadersController(ReaderContext context)
        {
            _context = context;
        }

        // GET: api/Readers
        [HttpGet]
        public async Task<dynamic> GetReaders()
        {
            string name = HttpContext.Request.Query["name"].ToString();
            var readers = await _context.Readers.Include(r => r.Books).ToListAsync();
            if (name != null && name != string.Empty)
            {
                return readers.Find(reader => reader.FirstName.ToLower() == name.ToLower());
            }
            else
            {
                return readers;
            }
        }

        // GET: api/Readers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reader>> GetReader(int id)
        {
            var reader = await _context.Readers.FindAsync(id);

            if (reader == null)
            {
                return NotFound();
            }

            return reader;
        }

        // PUT: api/Readers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReader(int id, Reader reader)
        {
            if (id != reader.Id)
            {
                return BadRequest();
            }

            _context.Entry(reader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReaderExists(id))
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

        // POST: api/Readers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reader>> PostReader(Reader reader)
        {
            _context.Readers.Add(reader);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReader), new { id = reader.Id }, reader);
        }

        // DELETE: api/Readers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReader(int id)
        {
            var reader = await _context.Readers.FindAsync(id);
            if (reader == null)
            {
                return NotFound();
            }

            _context.Readers.Remove(reader);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReaderExists(int id)
        {
            return _context.Readers.Any(e => e.Id == id);
        }
    }
}
