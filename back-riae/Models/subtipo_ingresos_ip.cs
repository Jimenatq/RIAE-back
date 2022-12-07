using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_subtipo))]
    public class subtipo_ingresos_ip
    {
        public int id_subtipo { get; set; }

        //este campo es de tipos_ingresos
        public int id_tipo_registro { get; set; }
        public int subtipo_registro { get; set; }
        public string nombre_subtipo { get; set; }

        //[ForeignKey(nameof(id_tipo_registro))]
        //public tipos_ingresos tipos_ingresos { get; set; }
    }
}
