using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QSistemaLoja.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Preco { get; set; }

        [Display(Name = "Última Compra")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Estoque")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public float Estoque { get; set; }

        [Display(Name = "Comentário")]
        [DataType(DataType.MultilineText)]
        public string Comentario { get; set; }

        [JsonIgnore]
        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrdemDetalhe> OrdensDetalhes { get; set; }
    }
}