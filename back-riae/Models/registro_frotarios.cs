using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class registro_frotarios
    {
            public int id_registro_frotatorios { get; set; }

            public int id_tipo_registro { get; set; }

            public int n_recibo { get; set; }

            public int id_subtipo { get; set; }

            public int n_boleta_clasificador { get; set; }

            public int importe_total_boleta { get; set; }

            public int igv { get; set; }

            public int monto_igv { get; set; }

    }
}
