using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_subtipo))]
    public class subtipo_ingresos
    {
        public int id_subtipo { get; set; }
        public int tipo_registro { get; set; }
        [ForeignKey(nameof(tipo_registro))]
        public tipos_ingresos tipos_ingresos { get; set; } 
        public int subtipo_registro { get; set; }
        public string nombre_subtipo { get; set; }
    }
}
