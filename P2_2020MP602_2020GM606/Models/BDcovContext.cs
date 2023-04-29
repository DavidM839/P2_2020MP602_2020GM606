using Microsoft.EntityFrameworkCore;

namespace P2_2020MP602_2020GM606.Models
{
    public class BDcovContext : DbContext
    {
        public BDcovContext(DbContextOptions<BDcovContext> options) : base(options)
        {
        }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<CasosReportados> casosReportados { get; set; }

    }
}
