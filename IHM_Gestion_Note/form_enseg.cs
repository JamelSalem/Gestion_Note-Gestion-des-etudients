using Entities;
using Services;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;



namespace IHM_Gestion_Note
{
    public partial class form_enseg : MetroFramework.Forms.MetroForm
    {
        public form_enseg()
        {

            InitializeComponent();
        }
        List<Enseignant> LE = new List<Enseignant>();
        public Enseignant E;




        private void Affiche_Ens()
        {

            LE = EnseignantADO.List_Enseignant();
            DG_Prof.Rows.Clear();


            if (LE != null)
            {
                foreach (Enseignant E in LE)
                    DG_Prof.Rows.Add(E.num_Ens, E.nom, E.prenom, E.email, E.speciality, E.telephone,E.grade , E.department
                        );
            }
        }





        

     
        private void btn_del_ens_Click(object sender, EventArgs e)
        {
           

        }
        // Bouton Recherche de voiture par Immatriculation ou par Marque



            

        // événement de chargement du formulaire Enseignant

        private void form_enseg_Load(object sender, EventArgs e)
        {
            //// TODO: cette ligne de code charge les données dans la table 'base_NoteDataSet1.Enseignants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.enseignantsTableAdapter.Fill(this.base_NoteDataSet1.Enseignants);
            //// TODO: cette ligne de code charge les données dans la table 'base_NoteDataSet3.Enseignants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.enseignantsTableAdapter.Fill(this.base_NoteDataSet3.Enseignants);
            Affiche_Ens();

        }

        // bouton pour ajouter un nouvel enseignant

        private void btn_add_ens_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Id_Ens.Text))
                MessageBox.Show("saisir L'Identifient de l'Ensignant !");

            else
            {
                Enseignant E = new Enseignant
                {
                    num_Ens = Id_Ens.Text,
                    nom = nom_ens.Text,
                    prenom = pren_ens.Text,
                    email = email_ens.Text,
                    speciality = special_ens.Text,
                    telephone = tel_ens.Text,
                    grade = grade.Text,
                    department = dep.Text,


            };
                Enseignant E1 = EnseignantADO.Recherche_Code(Id_Ens.Text);

                if (E1 == null)
                {
                    if (!Directory.Exists("img"))
                        Directory.CreateDirectory("img");
                    img_ens.Image.Save("img/" + Id_Ens.Text +".jpg");


                    EnseignantADO.Ajouter(E);
                    Affiche_Ens();

                    img_ens.Image = new PictureBox().Image;

                }
                else
                    MessageBox.Show("Cet enseignant existe dejà");
            }
        }


            // bouton pour supprimer une voiture sélectionnée

        private void btn_remv_ens_Click(object sender, EventArgs e)
        {
            

            EnseignantADO.Supprimer(Id_Ens.Text);
                Affiche_Ens();

        }

        private void btn_edit_ens_Click_1(object sender, EventArgs e)
        {
            Enseignant E = new Enseignant
            {
                num_Ens = Id_Ens.Text,
                nom = nom_ens.Text,
                prenom = pren_ens.Text,
                email = email_ens.Text,
                speciality = special_ens.Text,
                telephone = tel_ens.Text,
                grade = grade.Text,
                department = dep.Text,


            };

            if (!Directory.Exists("img"))
            {
                Directory.CreateDirectory("img");
                img_ens.Image.Save("img/" + Id_Ens.Text + ".jpg");
            }
                EnseignantADO.Modifier(E);
                Affiche_Ens();

                img_ens.Image = new PictureBox().Image;
            

        }

        // bouton pour modifier un enseignant sélectionnée
        // Bouton Recherche d'un enseignant par code

        private void btn_srch_ens_Click_1(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(Id_Ens.Text))
                {
                    Enseignant E = EnseignantADO.Recherche_Code(Id_Ens.Text);
                    if (E != null)
                    {
                        Id_Ens.Text = E.num_Ens;
                        nom_ens.Text = E.nom;
                        pren_ens.Text = E.prenom;
                        email_ens.Text = E.email;
                        special_ens.Text = E.speciality;
                        tel_ens.Text = E.telephone;
                        grade.Text = E.grade;
                        dep.Text = E.department;

                        DG_Prof.Rows.Clear();

                        DG_Prof.Rows.Add(E.num_Ens, E.nom, E.prenom, E.email, E.speciality, E.telephone, E.grade, E.department);

                    }
                    else
                        MessageBox.Show("Aucune Enseignant trouvée", "attention");
                }
                else
            if (!string.IsNullOrEmpty(nom_ens.Text))
                {
                    List<Etudient> l = EtudientADO.Recherche_Nom(nom_ens.Text);
                    if (l.Count > 0)
                    {
                        DG_Prof.Rows.Clear();
                        foreach (var E in l)
                            DG_Prof.Rows.Add(E.num_Etud, E.nom, E.prenom, E.Groupe, E.tel, E.Genre, E.date_insc, E.date_PFE);
                    }
                    else
                        MessageBox.Show("Aucune Enseignant trouvée");
                }


            }

        private void btn_del_ens_Click_1(object sender, EventArgs e)
        {
            Id_Ens.Text = ""; Id_Ens.Focus();

            nom_ens.Text = "";
            pren_ens.Text = "";
            email_ens.Text = "";
            special_ens.Text = "";
            tel_ens.Text = "";
            grade.Text = "";
            dep.Text = "";
            img_ens.Image = new PictureBox().Image;


            Affiche_Ens();
        }
       
        
        // événement qui se déclenche lors d'un double click sur une ligne du DataGridView
        //(sélection d'un Enseignant)
        private void DG_Prof_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


            int ind = DG_Prof.CurrentRow.Index;
            Id_Ens.Text = DG_Prof[0, ind].Value.ToString();
            nom_ens.Text = DG_Prof[1, ind].Value.ToString();
            pren_ens.Text = DG_Prof[2, ind].Value.ToString();
            email_ens.Text = DG_Prof[3, ind].Value.ToString();
           special_ens.Text = DG_Prof[4, ind].Value.ToString();
            //tel_ens.Text = DG_Prof[5, ind].Value.ToString();
            //grade.Text = DG_Prof[6, ind].Value.ToString();
            //dep.Text = DG_Prof[7, ind].Value.ToString();
            string mypath = "img/" + DG_Prof[0, ind].Value.ToString()+".jpg";
            if (File.Exists(mypath))
                img_ens.Image = Image.FromFile(mypath);

            
        }

        private void btn_clse_ens_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_bro_etud_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            img_ens.Image = Image.FromFile(openFileDialog1.FileName);

        }
    }
    

}




