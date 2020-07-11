using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Services
{
    public class AbsanceADO
    {
        public static void Ajouter(Absance AB)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                context.Absance.Add(AB);
                context.SaveChanges();
            }
        }
        public static void Retourner_Abs(string Num, string num_Etud, int NB_ABS)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                var req1 = from a in context.Absance
                           where a.Num_Abs == Num
                           select a;
                Absance A = req1.SingleOrDefault();

                //A.nb_abs = NB_ABS;
                var req2 = from e in context.Etudient
                           where e.num_Etud == num_Etud
                           select e;

                context.SaveChanges();
            }
        }
        //Liste des locations en cours d'un client
        public static List<Absance> List_Abs_etud(string num_Etud)
        {
            using (DbNoteEntitie context = new DbNoteEntitie())
            {
                List<Absance> A = (from a in context.Absance
                                   where a.num_Etud == num_Etud
                                   select a).ToList();
                return A;
            }
        }
    }
}