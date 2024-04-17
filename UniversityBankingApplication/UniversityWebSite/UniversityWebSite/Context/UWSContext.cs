using Microsoft.EntityFrameworkCore;
using UniversityWebSite.Entities;

namespace UniversityWebSite.Context
{
    public class UWSContext : DbContext
    {
        public UWSContext(DbContextOptions<UWSContext> option) :base(option) 
        {
            
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
