namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoPropriedadeResponsavel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "Responsavel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "Responsavel");
        }
    }
}
