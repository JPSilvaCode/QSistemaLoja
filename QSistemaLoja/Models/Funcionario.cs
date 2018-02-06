using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSistemaLoja.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} deve possuir até 30 caracteres.")]
        public string Nome { get; set; }
        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Sobrenome { get; set; }
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Salario { get; set; }
        [Display(Name = "Comissão")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float Comissao { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[DataType(DataType.Date, ErrorMessage = "Data com formato inválido")]
        public DateTime Nascimento { get; set; }
        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Cadastro { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [NotMapped]
        public int Idade { get { return DateTime.Now.Year - Nascimento.Year; } }
        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TipoDocumentoId { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}