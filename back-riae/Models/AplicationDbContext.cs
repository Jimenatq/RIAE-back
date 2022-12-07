using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<tipos_ingresos> tipos_Registros { get; set; }
        public DbSet<subtipo_ingresos_ip> subtipo_Ingresos_IP { get; set; }
        public DbSet<subtipo_ingresos_fr> subtipo_Ingresos_FR { get; set; }
        public DbSet<registro_ipropios> registro_Ipropios { get; set; }
        //public DbSet<boleta_clasificadores> boleta_Clasificadores { get; set; }
        public DbSet<registro_frotatorios> registro_Frotatorios { get; set; }
        public DbSet<boleta_clasificadores> boleta_Clasificadores { get; set; }
        //public DbSet<glosa_fr1> glosa_FR1 { get; set; }
        //public DbSet<glosa_fr2> glosa_FR2 { get; set; }
        //public DbSet<glosa_fr3> glosa_FR3 { get; set; }
        //public DbSet<glosa_fr4> glosa_FR4 { get; set; }
    }
}
