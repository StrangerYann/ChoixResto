namespace ChoixResto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TP2_setp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restos", "Nom", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restos", "Nom", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
