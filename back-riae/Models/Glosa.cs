using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class Glosa
    {

        public int Pliego { get; set; }

        public int Subtipo { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NombreEmpresa { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string NotaInformativa { get; set; }
    }
}
