namespace ProjetoPromoWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertySenhaEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "Senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "Senha");
        }
    }
}
