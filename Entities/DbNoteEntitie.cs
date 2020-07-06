using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DbNoteEntitie : DbContext
    {
        public DbNoteEntitie() : base("BDNote") { }
       
        public virtual DbSet<Etudient> Etudient { get; set; }
    }
}
