namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlanoClassAndLinkToEmpresaClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planos",
                c => new
                    {
                        PlanoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Single(nullable: false),
                        Descricao = c.String(),
                        Empresa_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.PlanoId)
                .ForeignKey("dbo.Empresas", t => t.Empresa_EmpresaId)
                .Index(t => t.Empresa_EmpresaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planos", "Empresa_EmpresaId", "dbo.Empresas");
            DropIndex("dbo.Planos", new[] { "Empresa_EmpresaId" });
            DropTable("dbo.Planos");
        }
    }
}
