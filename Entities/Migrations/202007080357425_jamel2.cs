namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jamel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Etudients", "date_PFE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Etudients", "date_PFE");
        }
    }
}
