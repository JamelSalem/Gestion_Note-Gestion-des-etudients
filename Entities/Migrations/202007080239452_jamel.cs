namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jamel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Absances",
                c => new
                    {
                        Num_Abs = c.String(nullable: false, maxLength: 128),
                        codeModule = c.String(maxLength: 128),
                        num_Etud = c.String(maxLength: 128),
                        dateabs = c.DateTime(nullable: false),
                        nb_abs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Num_Abs)
                .ForeignKey("dbo.Etudients", t => t.num_Etud)
                .ForeignKey("dbo.Modules", t => t.codeModule)
                .Index(t => t.codeModule)
                .Index(t => t.num_Etud);
            
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
                        date_insc = c.String(),
                        DteFinEtude = c.String(),
                    })
                .PrimaryKey(t => t.num_Etud);
            
            CreateTable(
                "dbo.Enseignants",
                c => new
                    {
                        num_Ens = c.String(nullable: false, maxLength: 128),
                        nom = c.String(),
                        prenom = c.String(),
                        email = c.String(),
                        speciality = c.String(),
                        telephone = c.Int(nullable: false),
                        grade = c.String(),
                        department = c.String(),
                    })
                .PrimaryKey(t => t.num_Ens);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        codeModule = c.String(nullable: false, maxLength: 128),
                        nomModule = c.String(),
                        Note_TP = c.Single(nullable: false),
                        Note_Cours = c.Single(nullable: false),
                        Note_Module = c.Single(nullable: false),
                        nb_Absance = c.Int(nullable: false),
                        regime = c.String(),
                        coéffission = c.Single(nullable: false),
                        semestre = c.Int(nullable: false),
                        année = c.Int(nullable: false),
                        Enseignant_num_Ens = c.String(maxLength: 128),
                        Etudient_num_Etud = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.codeModule)
                .ForeignKey("dbo.Enseignants", t => t.Enseignant_num_Ens)
                .ForeignKey("dbo.Etudients", t => t.Etudient_num_Etud)
                .Index(t => t.Enseignant_num_Ens)
                .Index(t => t.Etudient_num_Etud);
            
            CreateTable(
                "dbo.EnseignantEtudients",
                c => new
                    {
                        Enseignant_num_Ens = c.String(nullable: false, maxLength: 128),
                        Etudient_num_Etud = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Enseignant_num_Ens, t.Etudient_num_Etud })
                .ForeignKey("dbo.Enseignants", t => t.Enseignant_num_Ens, cascadeDelete: true)
                .ForeignKey("dbo.Etudients", t => t.Etudient_num_Etud, cascadeDelete: true)
                .Index(t => t.Enseignant_num_Ens)
                .Index(t => t.Etudient_num_Etud);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Absances", "codeModule", "dbo.Modules");
            DropForeignKey("dbo.Absances", "num_Etud", "dbo.Etudients");
            DropForeignKey("dbo.Modules", "Etudient_num_Etud", "dbo.Etudients");
            DropForeignKey("dbo.Modules", "Enseignant_num_Ens", "dbo.Enseignants");
            DropForeignKey("dbo.EnseignantEtudients", "Etudient_num_Etud", "dbo.Etudients");
            DropForeignKey("dbo.EnseignantEtudients", "Enseignant_num_Ens", "dbo.Enseignants");
            DropIndex("dbo.EnseignantEtudients", new[] { "Etudient_num_Etud" });
            DropIndex("dbo.EnseignantEtudients", new[] { "Enseignant_num_Ens" });
            DropIndex("dbo.Modules", new[] { "Etudient_num_Etud" });
            DropIndex("dbo.Modules", new[] { "Enseignant_num_Ens" });
            DropIndex("dbo.Absances", new[] { "num_Etud" });
            DropIndex("dbo.Absances", new[] { "codeModule" });
            DropTable("dbo.EnseignantEtudients");
            DropTable("dbo.Modules");
            DropTable("dbo.Enseignants");
            DropTable("dbo.Etudients");
            DropTable("dbo.Absances");
        }
    }
}
