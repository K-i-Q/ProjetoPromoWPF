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
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<EmpresaCliente> EmpresaCliente { get; set; }
        
    }
}
