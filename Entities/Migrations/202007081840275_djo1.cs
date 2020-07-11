namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class djo1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Modules", "Note_TP", c => c.String());
            AlterColumn("dbo.Modules", "Note_Cours", c => c.String());
            AlterColumn("dbo.Modules", "Note_Module", c => c.String());
            AlterColumn("dbo.Modules", "nb_Absance", c => c.String());
            AlterColumn("dbo.Modules", "coéffission", c => c.String());
            AlterColumn("dbo.Modules", "semestre", c => c.String());
            AlterColumn("dbo.Modules", "année", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Modules", "année", c => c.Int(nullable: false));
            AlterColumn("dbo.Modules", "semestre", c => c.Int(nullable: false));
            AlterColumn("dbo.Modules", "coéffission", c => c.Single(nullable: false));
            AlterColumn("dbo.Modules", "nb_Absance", c => c.Int(nullable: false));
            AlterColumn("dbo.Modules", "Note_Module", c => c.Single(nullable: false));
            AlterColumn("dbo.Modules", "Note_Cours", c => c.Single(nullable: false));
            AlterColumn("dbo.Modules", "Note_TP", c => c.Single(nullable: false));
        }
    }
}
