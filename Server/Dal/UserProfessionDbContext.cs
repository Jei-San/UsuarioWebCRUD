using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWebCRUD.Shared;

namespace UserWebCRUD.Server
{
    public class UserProfessionDbContext : DbContext
    {
        public UserProfessionDbContext(DbContextOptions<UserProfessionDbContext> options) 
            : base(options)
        {

        }
        public DbSet<UserInfo> UsersInfo { get; set; }
        public DbSet<ProfessionInfo> ProfessionsInfo { get; set; }
        public DbSet<UserProfessionInfo> UserProfessionsInfo { get; set; }
    }
}
