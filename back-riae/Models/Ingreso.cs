using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class Ingreso
    {
        public int Id { get; set; }

        public int Pliego { get; set; }

        public int Tipo { get; set; }

        public int Subtipo { get; set; }

        public int Codigo { get; set; }

        public int Clasificador { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Concepto { get; set; }

        [Required]
        public bool Glosa { get; set; }

        public int ImporteT { get; set; }
    }
}
