namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoPropriedadeNivelNaClasseEmpresaCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientesDaEmpresa", "Nivel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientesDaEmpresa", "Nivel");
        }
    }
}
