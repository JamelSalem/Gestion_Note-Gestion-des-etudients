namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jamel1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Etudients", "DteFinEtude");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Etudients", "DteFinEtude", c => c.String());
        }
    }
}
