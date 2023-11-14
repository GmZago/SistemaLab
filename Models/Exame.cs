﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaExame.Models
{
    [Table("Exame")]
    public class Exame
    {
        [Column("ExameId")]
        [Display(Name = "Cód. Exame")]
        public int ExameId { get; set; }

        [Column("ExameNome")]
        [Display(Name = "Nome do Exame")]
        public string ExameNome { get; set; } = string.Empty;

        [Column("ExameObservacao")]
        [Display(Name = "Observacao do Exame")]
        public string ExameObservacao { get; set; } = string.Empty;

        [Column("ExameMaterial")]
        [Display(Name = "Material do Exame")]
        public string ExameMaterial { get; set; } = string.Empty;
    }
}
