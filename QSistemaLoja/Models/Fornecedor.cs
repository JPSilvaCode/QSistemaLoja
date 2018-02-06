using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QSistemaLoja.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Sobrenome { get; set; }
        [Display(Name = "Telefone")]        
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }
    }
}