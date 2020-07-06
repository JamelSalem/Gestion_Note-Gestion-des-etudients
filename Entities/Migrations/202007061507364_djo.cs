namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class djo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Etudients",
                c => new
                    {
                        num_Etud = c.String(nullable: false, maxLength: 128),
                        nom = c.String(),
                        prenom = c.String(),
                        Groupe = c.String(),
                        tel = c.String(),
                        Genre = c.String(),
                        date_nais = c.String(),
                        date_insc = c.String(),
                    })
                .PrimaryKey(t => t.num_Etud);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Etudients");
        }
    }
}
