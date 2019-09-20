namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassBeneficio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficios",
                c => new
                    {
                        BeneficioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nivel = c.Int(nullable: false),
                        Descricao = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                        Empresa_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.BeneficioId)
                .ForeignKey("dbo.Empresas", t => t.Empresa_EmpresaId)
                .Index(t => t.Empresa_EmpresaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beneficios", "Empresa_EmpresaId", "dbo.Empresas");
            DropIndex("dbo.Beneficios", new[] { "Empresa_EmpresaId" });
            DropTable("dbo.Beneficios");
        }
    }
}
