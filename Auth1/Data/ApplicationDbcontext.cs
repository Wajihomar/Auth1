using Microsoft.EntityFrameworkCore;
using Studentcontroller.Models;

namespace Studentcontroller.Data
{
    public class ApplicationDbcontext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Asp_55;Trusted_Connection=True;TrustServerCertificate=True");
        }
       public DbSet<User> Users { get; set; }
    }
}
