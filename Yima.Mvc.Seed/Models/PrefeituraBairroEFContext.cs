using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class PrefeituraBairroEFContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PrefeituraBairroEFContext() : base("name=PrefeituraBairroEFContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.TipoDocumento> TipoDocumentoes { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Fornecedor> Fornecedors { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Perfil> Perfils { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.Cidadao> Cidadaos { get; set; }

        public System.Data.Entity.DbSet<IssatisLab.Yima.Mvc.Seed.Models.OcorrenciaInterna> OcorrenciaInternas { get; set; }
    }
}
