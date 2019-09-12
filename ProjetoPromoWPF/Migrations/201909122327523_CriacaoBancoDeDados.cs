namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBancoDeDados : DbMigration
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
                "dbo.ClientesDaEmpresa",
                c => new
                    {
                        EmpresaClienteId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        EmpresaId = c.Int(nullable: false),
                        ContratadaEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaClienteId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpresaId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientesDaEmpresa", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.ClientesDaEmpresa", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.ClientesDaEmpresa", new[] { "EmpresaId" });
            DropIndex("dbo.ClientesDaEmpresa", new[] { "ClienteId" });
            DropTable("dbo.Empresas");
            DropTable("dbo.ClientesDaEmpresa");
            DropTable("dbo.Clientes");
            DropTable("dbo.Administradores");
        }
    }
}
