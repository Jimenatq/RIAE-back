using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class Ingreso
    {
        public int Id { get; set; }

        public int Pliego { get; set; }

        public int Tipo { get; set; }

        [Required]
        public int Subtipo { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public int Clasificador { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Concepto { get; set; }

        [Required]
        public int ImporteClasificador { get; set; }

        [Required]
        public int ImporteTotal { get; set; }

        [Required]
        public bool Glosa { get; set; }

    }
}
