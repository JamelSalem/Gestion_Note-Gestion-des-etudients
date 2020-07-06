using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EtudientADO
    {
        // Ajout de nouvelle Etudient
        public static void Ajouter(Etudient E)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                context.Etudient.Add(E);
                context.SaveChanges();
            }
        }
        // modifier les données d'une Etudient existant
        public static void Modifier(Etudient E)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Etudient oldEt = context.Etudient.Find(E.num_Etud);
                if (oldEt != null)
                {
                    oldEt.nom = E.nom;
                    oldEt.prenom = E.prenom;
                    oldEt.Groupe = E.Groupe;
                    oldEt.tel = E.tel;
                    oldEt.Genre = E.Genre;
                    oldEt.date_nais = E.date_nais;
                    oldEt.date_insc = E.date_insc;


                }
                context.SaveChanges();
            }
        }

        //supprimer une Etudient ayant le code en paramètre
        public static void Supprimer(string numEtud)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Etudient E = context.Etudient.Find(numEtud);
                if (E != null)
                {
                    context.Etudient.Remove(E);
                    context.SaveChanges();
                }
            }
        }

        // recherche Etudient par Code
        public static Etudient Recherche_Code(string numEtud)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                return context.Etudient.Where(x => x.num_Etud == numEtud).SingleOrDefault();

            }
        }
        // recherche Etudient par Code
        public static List<Etudient>  Recherche_Nom(string nom)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            
                {
                    return context.Etudient.Where(x => x.nom.Contains(nom)).ToList();
                }
            
        }
        

        //Liste Etudient 
        public static List<Etudient> List_Etudient()
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                // return context.Groupe.Where(x => x.codeGroupe == codeGroupe).SingleOrDefault();

                List<Etudient> req = (from e in context.Etudient
                                      select e).ToList();
                return req;
            }
            //}

            // recherche Etudient par semestre
            //public static List<Etudient> Recherche_Semestre(int semestre)
            //{
            //    using (DbNoteEntitie context = new DbNoteEntitie())
            //    {

            //        List<Etudient> req = (from e in context.Etudient
            //                              where e.semestre == semestre
            //                              select e).ToList();
            //        return req;
            //    }
            //}

            // recherche Etudient par Année
            //public static List<Etudient> Recherche_Année(int année,string codeMatiere)
            //{
            //    using (DbNoteEntitie context = new DbNoteEntitie())
            //    {
            //        List<Etudient> req = (from e in context.Etudient
            //                              where e.année == année
            //                              select e).ToList();
            //        return req;
            //    }

        }
    }
}
