using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_tipo_registro))]
    public class tipos_ingresos
    {
        public int id_tipo_registro { get; set; }
        public int tipo_registro { get; set; }
        public string nombre_registro { get; set; }
    }
}
