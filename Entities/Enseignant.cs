using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entities
{
    public class Enseignant
    {
        [Key]
        public string num_Ens { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string speciality { get; set; }
        public string telephone { get; set; }
        public string grade { get; set; }
        public string department { get; set; }

        


        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<Etudient> Etudients { get; set; }

        public Enseignant(string num_Ens, string nom, string prenom, string email, string speciality, string telephone, string grade, string department)
        {
            this.num_Ens = num_Ens;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.speciality = speciality;
            this.telephone = telephone;
            this.grade = grade;
            this.department = department;
        }

        public Enseignant()
        {
        }


        public string toString()
        {
            string s = "Num: " + num_Ens + ", Nom: " + nom + " prenom: " + prenom + " email: " + email + " tele: " + telephone + "  Ton Grade : " + grade + " Département: " + department;
            return s;
        }
    }
}
