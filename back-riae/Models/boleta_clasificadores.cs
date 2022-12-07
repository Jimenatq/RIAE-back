using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    //[PrimaryKey(nameof(id_boleta_clasificador))]
    public class boleta_clasificadores
    {
        [Key]
        public int id_boleta_clasificador { get; set; }
        public int tipo_registro { get; set; }
        public int? codigo { get; set; }
        public int cod_clasificador { get; set; }
        public string nombre_clasificador { get; set; }
        public float importe_unitario_clasificador { get; set; }

    }
}
