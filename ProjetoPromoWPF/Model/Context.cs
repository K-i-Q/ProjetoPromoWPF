using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    class Context : DbContext
    {
        //Nomear o arquivo do banco de dados
        public Context() : base("DbProjetoPromoWPF")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaCliente> EmpresaCliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpresaCliente>()
                .HasKey(o => new { o.ClienteId, o.EmpresaId });
        }
    }
}
