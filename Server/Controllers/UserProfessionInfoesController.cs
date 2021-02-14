using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserWebCRUD.Server;
using UserWebCRUD.Shared;

namespace UsuarioWebCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfessionInfoesController : ControllerBase
    {
        private readonly UserProfessionDbContext _context;

        public UserProfessionInfoesController(UserProfessionDbContext context)
        {
            _context = context;
        }

        // GET: api/UserProfessionInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfessionInfo>>> GetUserProfessionsInfo()
        {
            return await _context.UserProfessionsInfo.ToListAsync();
        }

        // GET: api/UserProfessionInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfessionInfo>> GetUserProfessionInfo(int id)
        {
            var userProfessionInfo = await _context.UserProfessionsInfo.FindAsync(id);

            if (userProfessionInfo == null)
            {
                return NotFound();
            }

            return userProfessionInfo;
        }

        // PUT: api/UserProfessionInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProfessionInfo(int id, UserProfessionInfo userProfessionInfo)
        {
            if (id != userProfessionInfo.UserProfessionId)
            {
                return BadRequest();
            }

            _context.Entry(userProfessionInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserProfessionInfoExists(id))
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

        // POST: api/UserProfessionInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserProfessionInfo>> PostUserProfessionInfo(UserProfessionInfo userProfessionInfo)
        {
            _context.UserProfessionsInfo.Add(userProfessionInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserProfessionInfo", new { id = userProfessionInfo.UserProfessionId }, userProfessionInfo);
        }

        // DELETE: api/UserProfessionInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProfessionInfo(int id)
        {
            var userProfessionInfo = await _context.UserProfessionsInfo.FindAsync(id);
            if (userProfessionInfo == null)
            {
                return NotFound();
            }

            _context.UserProfessionsInfo.Remove(userProfessionInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserProfessionInfoExists(int id)
        {
            return _context.UserProfessionsInfo.Any(e => e.UserProfessionId == id);
        }
    }
}
