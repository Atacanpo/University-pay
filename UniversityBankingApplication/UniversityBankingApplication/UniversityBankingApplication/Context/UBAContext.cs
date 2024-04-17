using Microsoft.EntityFrameworkCore;
using UniversityBankingApplication.Entities;

namespace UniversityBankingApplication.Context
{
    public class UBAContext : DbContext
    {
        public UBAContext(DbContextOptions<UBAContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
