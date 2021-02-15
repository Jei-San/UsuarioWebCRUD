using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioWebCRUD.Shared;

namespace UsuarioWebCRUD.Server.Dal
{
    public class UserProfessionDbContext : DbContext
    {
        public UserProfessionDbContext(DbContextOptions<UserProfessionDbContext> options) 
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<UserProfession> UserProfessions { get; set; }
    }
}
