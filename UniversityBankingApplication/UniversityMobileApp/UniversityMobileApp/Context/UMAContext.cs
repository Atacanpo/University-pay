using Microsoft.EntityFrameworkCore;
using UniversityMobileApp.Entity;

namespace UniversityMobileApp.Context
{
    public class UMAContext : DbContext
    {
        public UMAContext(DbContextOptions<UMAContext> option) : base(option) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
