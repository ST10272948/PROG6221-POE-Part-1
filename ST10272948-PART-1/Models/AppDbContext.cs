using Microsoft.EntityFrameworkCore;
using ST10272948.Models;

namespace ST10272948_PART_1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=CMCS;Trusted_Connection=True;");
        }
    }

}
