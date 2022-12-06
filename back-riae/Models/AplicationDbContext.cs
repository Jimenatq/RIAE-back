using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<tipos_ingresos> tipos_Registros { get; set; }
        public DbSet<subtipo_ingresos> subtipo_Ingresos { get; set; }
        //public DbSet<registro_ipropios> registro_Ipropios { get; set; }
        //public DbSet<boleta_clasificadores_ip> boleta_Clasificadores { get; set; }
        //public DbSet<registro_frotatorios> registro_Frotatorios { get; set; }
        //public DbSet<boleta_clasificadores_fr> boleta_Clasificadores_FR { get; set; }
    }
}
