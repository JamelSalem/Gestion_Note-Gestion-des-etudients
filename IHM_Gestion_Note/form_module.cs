using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM_Gestion_Note
{
    public partial class form_module : MetroFramework.Forms.MetroForm
    {
        public form_module()
        {
            InitializeComponent();
        }

        List<Module> LM = new List<Module>();
        public Module M;

        private void form_module_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'base_NoteDataSet2.Etudients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudientsTableAdapter.Fill(this.base_NoteDataSet2.Etudients);
            // TODO: cette ligne de code charge les données dans la table 'base_NoteDataSet1.Enseignants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.enseignantsTableAdapter.Fill(this.base_NoteDataSet1.Enseignants);
            // TODO: cette ligne de code charge les données dans la table 'base_NoteDataSet.Modules'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // this.modulesTableAdapter.Fill(this.base_NoteDataSet.Modules);
            Affiche_Mod();

        }

        private void Affiche_Mod()
        {

            LM = ModuleADO.List_Modules();
            DG_Mod.Rows.Clear();


            if (LM != null)
            {
                foreach (Module M in LM)
                    DG_Mod.Rows.Add(M.codeModule, M.nomModule, M.Note_TP, M.Note_Cours, M.Note_Module, M.nb_Absance, M.regime, M.coéffission,M.semestre,M.année
                        );
            }
        }

        private void btn_add_ens_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_mod.Text))
                MessageBox.Show("saisir L'Identifient de l'Etudient !");

            else
            {
                Module M = new Module
                {
                    codeModule = Id_mod.Text,
                    nomModule = nom_mod.Text,
                    Note_TP = noteTP.Text,
                    Note_Cours = noteCours.Text,
                    Note_Module = noteModule.Text,
                    nb_Absance =nbAbsance.Text,
                    regime = regime.Text,
                    semestre = semestre.Text,
                    année = annUniv.Text,
                    coéffission = coff.Text,
                    



                };
                Module M1 = ModuleADO.Recherche_Code_mod(Id_mod.Text);

                if (M1 == null)
                {
                    ModuleADO.Ajouter(M);
                    Affiche_Mod();
                }
                else
                    MessageBox.Show("Cet étudient existe dejà");
            }
        }

        private void btn_remv_Mod_Click(object sender, EventArgs e)
        {
            ModuleADO.Supprimer(Id_mod.Text);
            Affiche_Mod();
        }

        private void btn_edit_Mod_Click(object sender, EventArgs e)
        {
            Module M = new Module
            {
                codeModule = Id_mod.Text,
                nomModule = nom_mod.Text,
                Note_TP = noteTP.Text,
                Note_Cours = noteCours.Text,
                Note_Module = noteModule.Text,
                nb_Absance = nbAbsance.Text,
                regime = regime.Text,
                coéffission = coff.Text,
                semestre = semestre.Text,
                année = annUniv.Text,

            };

            ModuleADO.Modifier(M);
            Affiche_Mod();
        }

        private void DG_Mod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = DG_Mod.CurrentRow.Index;
            Id_mod.Text = DG_Mod[0, ind].Value.ToString();
            nom_mod.Text = DG_Mod[1, ind].Value.ToString();
            noteTP.Text = DG_Mod[2, ind].Value.ToString();
            noteCours.Text = DG_Mod[3, ind].Value.ToString();
            nom_mod.Text = DG_Mod[4, ind].Value.ToString();
            nbAbsance.Text = DG_Mod[5, ind].Value.ToString();
            regime.Text = DG_Mod[6, ind].Value.ToString();
            coff.Text = DG_Mod[7, ind].Value.ToString();
            semestre.Text = DG_Mod[7, ind].Value.ToString();
            annUniv.Text = DG_Mod[7, ind].Value.ToString();
            enseignant.Text=DG_Mod[8, ind].Value.ToString();
            //etudient.Text = DG_Mod[9, ind].Value.ToString();

        }

        private void btn_srch_Mod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id_mod.Text))
            {
                Module M = ModuleADO.Recherche_Code_mod(Id_mod.Text);
                if (M != null)
                {
                    Id_mod.Text = M.codeModule;
                    nom_mod.Text = M.nomModule;
                    noteTP.Text= M.Note_TP;
                    noteCours.Text = M.Note_Cours;
                    noteModule.Text = M.Note_Module;
                    nbAbsance.Text = M.nb_Absance;
                    regime.Text = M.regime;
                    coff.Text = M.coéffission;
                    semestre.Text = M.semestre;
                    annUniv.Text = M.année;

                    DG_Mod.Rows.Clear();

                    DG_Mod.Rows.Add(M.codeModule, M.nomModule, M.Note_TP, M.Note_Cours, M.Note_Module, M.nb_Absance, M.regime, M.coéffission,M.semestre,M.année) ;

                }
                else
                    MessageBox.Show("Aucune Module trouvée", "attention");
            }
            else
            if (!string.IsNullOrEmpty(nom_mod.Text))
            {
                List<Module> m = ModuleADO.Recherche_mod_nom(nom_mod.Text);
                if (m.Count > 0)
                {
                    DG_Mod.Rows.Clear();
                    foreach (var M in m)
                        DG_Mod.Rows.Add(M.codeModule, M.nomModule, M.Note_TP, M.Note_Cours, M.Note_Module, M.nb_Absance, M.regime, M.coéffission, M.semestre, M.année);
                }
                else
                    MessageBox.Show("Aucune Module trouvée");
            }

        }

        private void btn_del_Mod_Click(object sender, EventArgs e)
        {

            Id_mod.Text = ""; Id_mod.Focus();

            nom_mod.Text = "";
            noteTP.Text = "";
            noteCours.Text = "";
            noteModule.Text = "";
            nbAbsance.Text = "";
            regime.Text = "";
            coff.Text = "";
            semestre.Text = "";
            annUniv.Text = "";


            Affiche_Mod();

        }

        private void btn_clse_mod_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
