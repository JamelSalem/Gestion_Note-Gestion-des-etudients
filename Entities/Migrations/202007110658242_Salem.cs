namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Absances", "absTP", c => c.String());
            AddColumn("dbo.Absances", "absCours", c => c.String());
            AlterColumn("dbo.Absances", "dateabs", c => c.String());
            DropColumn("dbo.Absances", "nb_abs");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Absances", "nb_abs", c => c.Int(nullable: false));
            AlterColumn("dbo.Absances", "dateabs", c => c.DateTime(nullable: false));
            DropColumn("dbo.Absances", "absCours");
            DropColumn("dbo.Absances", "absTP");
        }
    }
}
