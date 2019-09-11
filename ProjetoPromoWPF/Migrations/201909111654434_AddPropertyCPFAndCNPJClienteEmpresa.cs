namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyCPFAndCNPJClienteEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CPF", c => c.String());
            AddColumn("dbo.Empresas", "CNPJ", c => c.String());
            AddColumn("dbo.Empresas", "Razao", c => c.String());
            DropColumn("dbo.Empresas", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empresas", "Nome", c => c.String());
            DropColumn("dbo.Empresas", "Razao");
            DropColumn("dbo.Empresas", "CNPJ");
            DropColumn("dbo.Clientes", "CPF");
        }
    }
}
