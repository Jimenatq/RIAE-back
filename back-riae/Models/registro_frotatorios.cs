using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class registro_frotatorios
    {
            public int id_registro_frotatorios { get; set; }

            public int id_tipo_registro { get; set; }

            public float n_recibo { get; set; }

            public int id_subtipo { get; set; }

            public int n_boleta_clasificador { get; set; }

            public float importe_total_boleta { get; set; }

            public float igv { get; set; }

            public float monto_igv { get; set; }

    }
}
