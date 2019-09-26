namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoDoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradores",
                c => new
                    {
                        AdministradorId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorId);
            
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
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        Razao = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Telefone = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
            CreateTable(
                "dbo.ClientesDaEmpresa",
                c => new
                    {
                        EmpresaClienteId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        EmpresaId = c.Int(nullable: false),
                        PlanoId = c.Int(nullable: false),
                        ContratadaEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaClienteId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .ForeignKey("dbo.Planos", t => t.PlanoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpresaId)
                .Index(t => t.PlanoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        DataNascimento = c.String(),
                        Genero = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Telefone = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Planos",
                c => new
                    {
                        PlanoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                        Descricao = c.String(),
                        Empresa_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.PlanoId)
                .ForeignKey("dbo.Empresas", t => t.Empresa_EmpresaId)
                .Index(t => t.Empresa_EmpresaId);
            
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
            DropForeignKey("dbo.ClientesDaEmpresa", "PlanoId", "dbo.Planos");
            DropForeignKey("dbo.Planos", "Empresa_EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.ClientesDaEmpresa", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.ClientesDaEmpresa", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Beneficios", "Empresa_EmpresaId", "dbo.Empresas");
            DropIndex("dbo.ParceiroDaEmpresa", new[] { "EmpresaUm_EmpresaId" });
            DropIndex("dbo.ParceiroDaEmpresa", new[] { "EmpresaDois_EmpresaId" });
            DropIndex("dbo.Planos", new[] { "Empresa_EmpresaId" });
            DropIndex("dbo.ClientesDaEmpresa", new[] { "PlanoId" });
            DropIndex("dbo.ClientesDaEmpresa", new[] { "EmpresaId" });
            DropIndex("dbo.ClientesDaEmpresa", new[] { "ClienteId" });
            DropIndex("dbo.Beneficios", new[] { "Empresa_EmpresaId" });
            DropTable("dbo.ParceiroDaEmpresa");
            DropTable("dbo.Planos");
            DropTable("dbo.Clientes");
            DropTable("dbo.ClientesDaEmpresa");
            DropTable("dbo.Empresas");
            DropTable("dbo.Beneficios");
            DropTable("dbo.Administradores");
        }
    }
}
