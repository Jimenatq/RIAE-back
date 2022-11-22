using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back_riae.Models
{
    public class Glosa
    {
        public int Pliego { get; set; }

        public int Subtipo { get; set; }

        public int n_cheque { get; set; }

        public int monto_cheque { get; set; }

        [Required]
        public string texto_glosa { get; set; }
    }
}
