namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassEmpresaEmpresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParceiroDaEmpresa",
                c => new
                    {
                        EmpresaEmpresaId = c.Int(nullable: false, identity: true),
                        EmpresaUmId = c.Int(nullable: false),
                        EmpresaDoisId = c.Int(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                        EmpresaDois_EmpresaId = c.Int(),
                        EmpresaUm_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpresaEmpresaId)
                .ForeignKey("dbo.Empresas", t => t.EmpresaDois_EmpresaId)
                .ForeignKey("dbo.Empresas", t => t.EmpresaUm_EmpresaId)
                .Index(t => t.EmpresaDois_EmpresaId)
                .Index(t => t.EmpresaUm_EmpresaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParceiroDaEmpresa", "EmpresaUm_EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.ParceiroDaEmpresa", "EmpresaDois_EmpresaId", "dbo.Empresas");
            DropIndex("dbo.ParceiroDaEmpresa", new[] { "EmpresaUm_EmpresaId" });
            DropIndex("dbo.ParceiroDaEmpresa", new[] { "EmpresaDois_EmpresaId" });
            DropTable("dbo.ParceiroDaEmpresa");
        }
    }
}
