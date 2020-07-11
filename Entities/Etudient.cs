//--------- Code de la classe Etudient ---------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Etudient
    {
        [Key]
        public string num_Etud { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string Groupe { get; set; }
        public string tel { get; set; }
        public string Genre { get; set; }
        public string date_insc { get; set; }
        public string date_PFE { get; set; }


        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<Absance> Absances { get; set; }
        public virtual ICollection<Enseignant> Enseignants { get; set; }



    }
}
