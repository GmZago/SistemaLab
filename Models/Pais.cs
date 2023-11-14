using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaExame.Models
{
    [Table("Pais")]
    public class Pais
    {

        [Column("PaisId")]
        [Display(Name = "Cód. Pais")]
        public int PaisId { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Pais Cidade")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
