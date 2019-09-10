namespace ChoixResto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1iDed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restos", "Nom", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restos", "Nom", c => c.String(nullable: false));
        }
    }
}
