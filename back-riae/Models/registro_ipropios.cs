using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class registro_ipropios
    {
        public int id_registro_ipropios { get; set; }

        public int id_tipo_registro { get; set; }

        public int n_recibo { get; set; }

        public int id_subtipo { get; set; }

        public int n_boleta_clasificadores { get; set; }

        public int importe_total_boleta { get; set; }

        public int n_cheque { get; set; }

        public int monto_cheque { get; set; }

        public string texto_glosa { get; set; }

    }
}
