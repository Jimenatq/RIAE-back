﻿using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class glosa_fr2
    {
        public int id_glosa { get; set; }
        public int n_recibo { get; set; }
        public string nombre_empresa { get; set; }
        public string nota_informativa { get; set; }
        public string nombre_factura { get; set; }
        public DateTime fecha { get; set; }
        public int importe_deposito { get; set; }
        public int importe_total_tipo_ip { get; set; }
        public int importe_total_tipo_fr { get; set; }
        public int n_voucher { get; set; }
        public int monto_voucher { get; set; }
        public int n_cheque { get; set; }
        public int monto_cheque { get; set; }
        public string nombre_banco { get; set; }
    }
}
