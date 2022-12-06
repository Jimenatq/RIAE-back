namespace back_riae.Models
{
    public class glosa_fr3
    {
        public int id_glosa { get; set; }
        public float n_recibo { get; set; }
        public string nombre_empresa { get; set; }
        public string nota_informativa { get; set; }
        public string nombre_factura { get; set; }
        public DateTime fecha { get; set; }
        public float importe_deposito { get; set; }
        public float importe_total_tipo_ip { get; set; }
        public float importe_total_tipo_fr { get; set; }
        public int n_nota_abono { get; set; }
        public float monto_nota_abono { get; set; }
    }
}
