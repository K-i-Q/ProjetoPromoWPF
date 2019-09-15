namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributePlanoIdToClassEmpresaCliente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientesDaEmpresa", "Plano_PlanoId", "dbo.Planos");
            DropIndex("dbo.ClientesDaEmpresa", new[] { "Plano_PlanoId" });
            RenameColumn(table: "dbo.ClientesDaEmpresa", name: "Plano_PlanoId", newName: "PlanoId");
            AlterColumn("dbo.ClientesDaEmpresa", "PlanoId", c => c.Int(nullable: false));
            CreateIndex("dbo.ClientesDaEmpresa", "PlanoId");
            AddForeignKey("dbo.ClientesDaEmpresa", "PlanoId", "dbo.Planos", "PlanoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientesDaEmpresa", "PlanoId", "dbo.Planos");
            DropIndex("dbo.ClientesDaEmpresa", new[] { "PlanoId" });
            AlterColumn("dbo.ClientesDaEmpresa", "PlanoId", c => c.Int());
            RenameColumn(table: "dbo.ClientesDaEmpresa", name: "PlanoId", newName: "Plano_PlanoId");
            CreateIndex("dbo.ClientesDaEmpresa", "Plano_PlanoId");
            AddForeignKey("dbo.ClientesDaEmpresa", "Plano_PlanoId", "dbo.Planos", "PlanoId");
        }
    }
}
