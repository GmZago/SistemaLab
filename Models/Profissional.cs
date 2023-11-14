using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaExame.Models
{
    [Table("Profissional")]
    public class Profissional
    {

        [Column("ProfissionalId")]
        [Display(Name = "Cód. Profissional")]
        public int ProfissionalId { get; set; }

        [Column("ProfissionalNome")]
        [Display(Name = "Nome do Profissional")]
        public string ProfissionalNome { get; set; } = string.Empty;

        [ForeignKey("CargoId")]
        public int CargoId { get; set; }

        public Cargo? Cargo { get; set; }
    }
}
