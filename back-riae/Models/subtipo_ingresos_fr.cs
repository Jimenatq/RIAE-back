using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_subtipo))]
    public class subtipo_ingresos_fr
    {
        public int id_subtipo { get; set; }

        //este campo es de tipos_ingresos
        public int id_tipo_registro { get; set; }
        public int subtipo_registro { get; set; }
        public string nombre_subtipo { get; set; }
    }
}
