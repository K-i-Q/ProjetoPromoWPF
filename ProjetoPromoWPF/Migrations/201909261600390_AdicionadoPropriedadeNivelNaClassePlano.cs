namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoPropriedadeNivelNaClassePlano : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planos", "Nivel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planos", "Nivel");
        }
    }
}
