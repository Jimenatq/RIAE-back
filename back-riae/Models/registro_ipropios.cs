using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_registro_ipropios))]
    public class registro_ipropios
    {
        public int id_registro_ipropios { get; set; }
        public int id_tipo_registro { get; set; }
        public float n_recibo { get; set; }
        public int id_subtipo { get; set; }
        public int n_boleta_clasificadores { get; set; }
        public float importe_total_boleta { get; set; }
        public int n_cheque { get; set; }
        public float monto_cheque { get; set; }
        public string texto_glosa { get; set; }

        [ForeignKey(nameof(n_boleta_clasificadores))]
        public boleta_clasificadores_ip boleta_clasificadores_ip { get; set; }

    }
}
