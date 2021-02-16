using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsuarioWebCRUD.Server.Dal;
using UsuarioWebCRUD.Shared;
using UsuarioWebCRUD.Shared.Models;

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
        public async Task<ActionResult<IEnumerable<UserProfession>>> GetUserProfessionsInfo()
        {
            return await _context.UserProfessions.ToListAsync();
        }

        // GET: api/UserProfessionInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfession>> GetUserProfessionInfo(int id)
        {
            var userProfessionInfo = await _context.UserProfessions.FindAsync(id);

            if (userProfessionInfo == null)
            {
                return NotFound();
            }

            return userProfessionInfo;
        }


        // POST: api/UserProfessionInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserProfession>> PostUserProfessionInfo(ProfessionUserRequest profession)
        {
            var userProfessionInfo = new UserProfession { UserId = profession.UserId, ProfessionId = profession.ProfessionId };
            _context.UserProfessions.Add(userProfessionInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserProfessionInfo", new { id = userProfessionInfo.UserProfessionId }, userProfessionInfo);
        }

        // DELETE: api/UserProfessionInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProfessionInfo(int id)
        {
            var userProfessionInfo = await _context.UserProfessions.FindAsync(id);
            if (userProfessionInfo == null)
            {
                return NotFound();
            }

            _context.UserProfessions.Remove(userProfessionInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
} 
