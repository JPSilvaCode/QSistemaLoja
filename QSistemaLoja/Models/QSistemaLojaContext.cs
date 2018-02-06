using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace QSistemaLoja.Models
{
    public class QSistemaLojaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public QSistemaLojaContext() : base("name=QSistemaLojaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.TipoDocumento> TipoDocumentoes { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Fornecedor> Fornecedors { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Customizar> Customizars { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Ordem> Ordem { get; set; }
        public System.Data.Entity.DbSet<QSistemaLoja.Models.OrdemDetalhe> OrdemDetalhe { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<QSistemaLoja.Models.OrdemAPI> OrdemAPIs { get; set; }
    }
}
