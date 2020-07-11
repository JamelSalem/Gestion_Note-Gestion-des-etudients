using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EnseignantADO
    {
        // Ajout de nouvelle Etudient
        public static void Ajouter(Enseignant E)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                context.Enseignant.Add(E);
                context.SaveChanges();
            }
        }
        // modifier les données d'une Etudient existant
        public static void Modifier(Enseignant E)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Enseignant olEns = context.Enseignant.Find(E.num_Ens);
                if (olEns != null)
                {
                    olEns.nom = E.nom;
                    olEns.prenom = E.prenom;
                    olEns.email = E.email;
                    olEns.speciality = E.speciality;
                    olEns.telephone = E.telephone;
                    olEns.grade = E.grade;
                    olEns.department = E.department;



                }
                context.SaveChanges();
            }
        }

        //supprimer une Etudient ayant le code en paramètre
        public static void Supprimer(string numEns)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Enseignant E = context.Enseignant.Find(numEns);
                if (E != null)
                {
                    context.Enseignant.Remove(E);
                    context.SaveChanges();
                }
            }
        }

        // recherche Enseignant par Code
        public static Enseignant Recherche_Code(string numEns)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                return context.Enseignant.Where(x => x.num_Ens == numEns).SingleOrDefault();

            }
        }
        // recherche Etudient par Code
        public static List<Enseignant> Recherche_Nom(string nom)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())

            {
                return context.Enseignant.Where(x => x.nom.Contains(nom)).ToList();
            }

        }


        //Liste Etudient 
        public static List<Enseignant> List_Enseignant()
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                // return context.Groupe.Where(x => x.codeGroupe == codeGroupe).SingleOrDefault();

                List<Enseignant> req = (from e in context.Enseignant
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
