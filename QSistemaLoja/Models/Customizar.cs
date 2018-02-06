using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QSistemaLoja.Models
{
    public class Customizar
    {
        [Key]
        public int CustomizarId { get; set; }

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

        [Display(Name = "Documento")]
        public int Documento { get; set; }

        public int TipoDocumentoId { get; set; }

        public string NomeCompleto { get { return string.Format("{0} {1}", Nome, Sobrenome); } }

        [JsonIgnore]
        public virtual TipoDocumento TipoDocumento { get; set; }

        [JsonIgnore]
        public virtual ICollection<Ordem> Ordem { get; set; }
    }
}