using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsuarioWebCRUD.Server.Dal;
using UsuarioWebCRUD.Shared;

namespace UsuarioWebCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionInfoesController : ControllerBase
    {
        private readonly UserProfessionDbContext _context;

        public ProfessionInfoesController(UserProfessionDbContext context)
        {
            _context = context;
        }

        // GET: api/ProfessionInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profession>>> GetProfessionsInfo()
        {
            return await _context.Professions.ToListAsync();
        }

        // GET: api/ProfessionInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profession>> GetProfessionInfo(int id)
        {
            var professionInfo = await _context.Professions.FindAsync(id);

            if (professionInfo == null)
            {
                return NotFound();
            }

            return professionInfo;
        }

        // PUT: api/ProfessionInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionInfo(int id, Profession professionInfo)
        {
            if (id != professionInfo.ProfessionId)
            {
                return BadRequest();
            }

            _context.Entry(professionInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionInfoExists(id))
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

        // POST: api/ProfessionInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Profession>> PostProfessionInfo(Profession professionInfo)
        {
            _context.Professions.Add(professionInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessionInfo", new { id = professionInfo.ProfessionId }, professionInfo);
        }

        // DELETE: api/ProfessionInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessionInfo(int id)
        {
            var professionInfo = await _context.Professions.FindAsync(id);
            if (professionInfo == null)
            {
                return NotFound();
            }

            _context.Professions.Remove(professionInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessionInfoExists(int id)
        {
            return _context.Professions.Any(e => e.ProfessionId == id);
        }
    }
}
