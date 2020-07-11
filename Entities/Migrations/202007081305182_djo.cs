namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class djo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enseignants", "telephone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enseignants", "telephone", c => c.Int(nullable: false));
        }
    }
}
