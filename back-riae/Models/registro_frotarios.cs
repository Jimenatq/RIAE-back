using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class registro_frotarios
    {
            public int Id { get; set; }

            public int n_recibo { get; set; }

            public int Tipo { get; set; }

            [Required]
            public int Subtipo { get; set; }

            [Required]
            public int Codigo { get; set; }

            [Required]
            public int Clasificador { get; set; }

            [Required]
            public string Concepto { get; set; }

            [Required]
            public int ImporteClasificador { get; set; }

            [Required]
            public int ImporteTotal { get; set; }

            [Required]
            public bool Glosa { get; set; }

    }
}
