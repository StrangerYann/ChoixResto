namespace ChoixResto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tp1_fullTests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "MotDePasse", c => c.String(nullable: false));
            AlterColumn("dbo.Restos", "Nom", c => c.String(nullable: false));
            AlterColumn("dbo.Utilisateurs", "Prenom", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilisateurs", "Prenom", c => c.String());
            AlterColumn("dbo.Restos", "Nom", c => c.String());
            DropColumn("dbo.Utilisateurs", "MotDePasse");
        }
    }
}
