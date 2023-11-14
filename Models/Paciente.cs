using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaExame.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("PacienteId")]
        [Display(Name = "Cód. Paciente")]
        public int PacienteId { get; set; }

        [Column("PacienteNome")]
        [Display(Name = "Nome Paciente")]
        public string PacienteNome { get; set; } = string.Empty;

        [Column("PacienteSexo")]
        [Display(Name = "Sexo do Paciente")]
        public string PacienteSexo { get; set; } = string.Empty;

        [Column("PacienteCpf")]
        [Display(Name = "Cpf do Paciente")]
        public string PacienteCpf { get; set; } = string.Empty;

        [Column("PacienteTelefone")]
        [Display(Name = "Telefone do Paciente")]
        public string PacienteTelefone { get; set; } = string.Empty;

        [Column("PacienteNomeMae")]
        [Display(Name = "Nome da Mãe do Paciente")]
        public string PacienteNomeMae { get; set; } = string.Empty;

        [Column("PacienteTipoSangue")]
        [Display(Name = "Tipo Sanguineo do Paciente")]
        public string PacienteTipoSangue { get; set; } = string.Empty;

        [Column("PacienteIdade")]
        [Display(Name = "Idade do Paciente")]
        public string PacienteIdade { get; set; } = string.Empty;

        [Column("PacienteAlergia")]
        [Display(Name = "Alergia do Paciente")]
        public string PacienteAlergia { get; set; } = string.Empty;

        [Column("PacienteEndereco")]
        [Display(Name = "Endereco do Paciente")]
        public string PacienteEndereco { get; set; } = string.Empty;

        [Column("PacientePeso")]
        [Display(Name = "Peso do Paciente")]
        public double PacientePeso { get; set; }



        [Column("PacienteAltura")]
        [Display(Name = "Altura do Paciente")]
        public double PacienteAltura { get; set; }


        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

    }
}
