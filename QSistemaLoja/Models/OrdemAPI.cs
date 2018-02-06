using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QSistemaLoja.Models
{
    public class OrdemAPI
    {
        [Key]
        public int OrdemsId { get; set; }

        public DateTime OrdemData { get; set; }

        public Customizar Customizar { get; set; }

        public OrdemStatus OrdemStatus { get; set; }

        public ICollection<OrdemDetalhe> Detalhes { get; set; }
    }
}