using System.Data.Entity;

namespace Entities
{
    public class DbNoteEntitie : DbContext
    {
        public DbNoteEntitie() : base("BDNote") { }

        public virtual DbSet<Etudient> Etudient { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Enseignant> Enseignant { get; set; }
        public virtual DbSet<Absance> Absance { get; set; }

    }
}