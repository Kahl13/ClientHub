using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Data
{
    public class AppDbContext : DbContext  
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<MedicalAid> MedicalAids { get; set; }
        public DbSet<SchemeOption> SchemeOptions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }  

        public DbSet<SystemRole> SystemRoles { get; set; }
        public DbSet<RefreshTokenInfo> RefreshTokenInfo { get; set; }

    }
}
