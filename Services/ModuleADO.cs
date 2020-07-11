using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ModuleADO
    {
        // Ajout de nouvelle Etudient
        public static void Ajouter(Module M)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                context.Module.Add(M);
                context.SaveChanges();
            }
        }
        // modifier les données d'une Etudient existant
        public static void Modifier(Module M)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Module olMod = context.Module.Find(M.codeModule);
                if (olMod != null)
                {
                    olMod.nomModule = M.nomModule;
                    olMod.Note_TP = M.Note_TP;
                    olMod.Note_Cours = M.Note_Cours;
                    olMod.Note_Module = M.Note_Module;
                    olMod.nb_Absance = M.nb_Absance;
                    olMod.regime = M.regime;
                    olMod.coéffission = M.coéffission;
                    olMod.semestre = M.semestre;
                    olMod.année = M.année;
                    olMod.Enseignant = M.Enseignant;
                    olMod.Etudient = M.Etudient;


                }
                context.SaveChanges();
            }
        }

        //supprimer une Module ayant le code en paramètre
        public static void Supprimer(string codeModule)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                Module M = context.Module.Find(codeModule);
                if (M != null)
                {
                    context.Module.Remove(M);
                    context.SaveChanges();
                }
            }
        }

        // recherche module par Code
        public static Module Recherche_Code_mod(string numMod)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                return context.Module.Where(x => x.codeModule == numMod).SingleOrDefault();

            }
        }
        // recherche Etudient par Nom
        public static List<Module> Recherche_mod_nom(string nom)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())

            {

                List<Module> module = (from a in context.Module
                                     where a.nomModule == nom
                                     select a).ToList();
                return module;
            }

        }

        //Liste Module 
        public static List<Module> List_Modules()
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                // return context.Groupe.Where(x => x.codeGroupe == codeGroupe).SingleOrDefault();

                List<Module> req = (from m in context.Module
                                    select m).ToList();
                return req;
            }


        }
    }
}
