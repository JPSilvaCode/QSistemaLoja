using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QSistemaLoja.Models
{
    public class TipoDocumento
    {
        [Key]
        [Display(Name = "Tipo de Documento")]
        public int TipoDocumentoId { get; set; }
        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Customizar> Customizacao { get; set; }
    }
}