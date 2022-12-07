using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_riae.Models
{
    [PrimaryKey(nameof(id_registro))]
    public class registro_frotatorios
    {
        public int id_registro { get; set; }
        public int id_tipo_registro { get; set; }
        [Key]
        public int n_boleta { get; set; }
        public float n_recibo { get; set; }
        public int id_subtipo { get; set; }
        public float importe_total_boleta { get; set; }
        public float igv { get; set; }
        public float monto_igv { get; set; }
        public string? nombre_empresa { get; set; }
        public string? nota_informativa { get; set; }
        public string? nombre_factura { get; set; }
        public DateTime? fecha { get; set; }
        public float? importe_deposito { get; set; }
        public float? importe_total_tipo_ip { get; set; }
        public float? importe_total_tipo_fr { get; set; }
        public int? n_voucher { get; set; }
        public float? monto_voucher { get; set; }
        public int? n_cheque { get; set; }
        public float? monto_cheque { get; set; }
        public string? nombre_banco { get; set; }
        public int? n_nota_abono { get; set; }
        public float? monto_nota_abono { get; set; }
        public string? texto_glosa { get; set; }

        [ForeignKey(nameof(n_boleta))]
        public boleta_clasificadores? boleta_clasificadores { get; set; }
    }
}
