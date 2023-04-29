using Microsoft.EntityFrameworkCore;

namespace P2_2020MP602_2020GM606.Models
{
    public class BDcovContext : DbContext
    {
        public BDcovContext(DbContextOptions options) : base(options)
        {
        }
       // public DbSet<equipo> equipo { get; set; }

    }
}
