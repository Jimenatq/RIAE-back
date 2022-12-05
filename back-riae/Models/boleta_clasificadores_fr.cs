namespace back_riae.Models
{
    public class boleta_clasificadores_fr
    {
        public int id_boleta_clasificadores { get; set; }
        public int id_tipo_registro { get; set; }
        public int n_recibo { get; set; }
        public int codigo { get; set; }
        public int cod_clasificador { get; set; }
        public string nombre_clasificador { get; set; }
        public int importe_unitario_clasificador { get; set; }
    }
}
