using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class glosa_fr1
    {
        public int id_glosa { get; set; }

        public int n_recibo { get; set; }

        public int n_voucher { get; set; }

        public int monto_voucher { get; set; }

        public string nombre_banco { get; set; }
    }
}
