using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_registro))]
    public class registro_ipropios
    {
        public int id_registro { get; set; }
        public int id_tipo_registro { get; set; }
        [Key]
        public int n_boleta { get; set; }
        public float n_recibo { get; set; }
        public int id_subtipo { get; set; }
        public float importe_total_boleta { get; set; }
        public int? n_cheque { get; set; }
        public float? monto_cheque { get; set; }
        public string? texto_glosa { get; set; }

        [ForeignKey(nameof(n_boleta))]
        public boleta_clasificadores? boleta_clasificadores { get; set; }

    }
}
