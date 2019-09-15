namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyPlanoToClassEmpresaCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientesDaEmpresa", "Plano_PlanoId", c => c.Int());
            CreateIndex("dbo.ClientesDaEmpresa", "Plano_PlanoId");
            AddForeignKey("dbo.ClientesDaEmpresa", "Plano_PlanoId", "dbo.Planos", "PlanoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientesDaEmpresa", "Plano_PlanoId", "dbo.Planos");
            DropIndex("dbo.ClientesDaEmpresa", new[] { "Plano_PlanoId" });
            DropColumn("dbo.ClientesDaEmpresa", "Plano_PlanoId");
        }
    }
}
