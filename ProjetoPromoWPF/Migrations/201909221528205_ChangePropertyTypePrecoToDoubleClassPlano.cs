namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePropertyTypePrecoToDoubleClassPlano : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Planos", "Preco", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Planos", "Preco", c => c.Single(nullable: false));
        }
    }
}
