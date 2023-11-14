using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SistemaExame.Models
{
    [Table("Resultado")]
    public class Resultado
    {
        [Column("ResultadoId")]
        [Display(Name = "Cód. Resultado")]
        public int ResultadoId { get; set; }

        [Column("ResultadoExame")]
        [Display(Name = "Resultado do Exame")]
        public string ResultadoExame { get; set; } = string.Empty;

        [Column("DataRealizacao")]
        [Display(Name = "Data Realização do Exame")]
        public DateTime DataRealizacao { get; set; }

        [Column("ResultadoObservacao")]
        [Display(Name = "Observação do Exame")]
        public string ResultadoObservacao { get; set; } = string.Empty;

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        public Paciente? Paciente { get; set; }

        [ForeignKey("ExameId")]
        public int ExameId { get; set; }

        public Exame? Exame { get; set; }

        [ForeignKey("ProfissionalId")]
        public int ProfissionalId { get; set; }

        public Profissional? Profissional { get; set; }
    }
}
