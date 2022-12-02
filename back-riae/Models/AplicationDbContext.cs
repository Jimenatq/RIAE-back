using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<tipos_registros> tipos_Registros { get; set; }
    }
}
