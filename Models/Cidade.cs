using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaExame.Models
{
    [Table("Cidade")]
    public class Cidade
    {

        [Column("CidadeId")]
        [Display(Name = "Cód. Cidade")]
        public int CidadeId { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        public int PaisId { get; set; }

        public Pais? Pais { get; set; }
    }
}
