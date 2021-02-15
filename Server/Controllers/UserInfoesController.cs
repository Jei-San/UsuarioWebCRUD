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
    public class UserInfoesController : ControllerBase
    {
        private readonly UserProfessionDbContext _context;

        public UserInfoesController(UserProfessionDbContext context)
        {
            _context = context;
        }

        // GET: api/UserInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersInfo()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/UserInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<UserData>>> GetUserInfo(int id)
        {
            List<UserData> userInfo = new List<UserData>();
            userInfo = await _context.Users
                .Join(_context.UserProfessions, 
                    u => u.UserId, 
                    up => up.UserId, 
                    (u, up) => 
                    new UserData { 
                        User = u, 
                        UserProfession = up 
                    } 
                )
                .Join(_context.Professions,
                        u => u.UserProfession.ProfessionId, 
                        p => p.ProfessionId,
                        (u, p) => 
                        new UserData { 
                            User = u.User, 
                            UserProfession = u.UserProfession, 
                            Profession = p 
                        }
                )
                .ToListAsync<UserData>();

            if (userInfo.Count < 1)
            {
                var user = await _context.Users.FindAsync(id);
                userInfo.Add(new UserData { User = user });
            }
            return userInfo;
        }

        // PUT: api/UserInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserInfo(int id, User userInfo)
        {
            if (id != userInfo.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserInfoExists(id))
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

        // POST: api/UserInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUserInfo(User userInfo)
        {
            _context.Users.Add(userInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserInfo", new { id = userInfo.UserId }, userInfo);
        }

        // DELETE: api/UserInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserInfo(int id)
        {
            var userInfo = await _context.Users.FindAsync(id);
            if (userInfo == null)
            {
                return NotFound();
            }

            _context.Users.Remove(userInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserInfoExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
