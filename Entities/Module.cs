using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Module
    {
       
        [Key]

        public String codeModule { get; set; }
        public String nomModule { get; set; }
        public string Note_TP { get; set; }
        public string Note_Cours { get; set; }
        public string Note_Module { get; set; }
        public string nb_Absance { get; set; }
        public string regime { get; set; }
        public string coéffission { get; set; }
        public string semestre { get; set; }
        public string année { get; set; }


        

        public virtual Enseignant Enseignant { get; set; }
        public virtual Etudient Etudient { get; set; }
        public virtual ICollection<Absance> Absances { get; set; }



        public Module()
        {
        }

        public Module(string codeModule, string nomModule, string note_TP, string note_Cours, string note_Module, string nb_Absance, string regime, string coéffission, string semestre, string année)
        {
            this.codeModule = codeModule;
            this.nomModule = nomModule;
            this.Note_TP = note_TP;
            this.Note_Cours = note_Cours;
            this.Note_Module = note_Module;
            this.nb_Absance = nb_Absance;
            this.regime = regime;
            this.coéffission = coéffission;
            this.semestre = semestre;
            this.année = année;
            
        }
    }
}

