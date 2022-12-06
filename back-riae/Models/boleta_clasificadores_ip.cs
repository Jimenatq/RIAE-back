using Microsoft.EntityFrameworkCore;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_boleta_clasificadores))]
    public class boleta_clasificadores_ip
    {
        public int id_boleta_clasificadores { get; set; }
        public int tipo_registro { get; set; }
        public float n_recibo { get; set; }
        public int cod_clasificador { get; set; }
        public string nombre_clasificador { get; set; }
        public float importe_unitario_clasificador { get; set; }

    }
}
