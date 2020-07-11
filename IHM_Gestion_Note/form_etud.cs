using Entities;
using Services;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace IHM_Gestion_Note
{
    public partial class form_etud : MetroFramework.Forms.MetroForm
    {
        public form_etud()
        {

            InitializeComponent();
        }
         List<Etudient> LE = new List<Etudient>();
        public Etudient E;


       
        private void Affiche_Etud()
        {

            LE = EtudientADO.List_Etudient();
            DG_Student.Rows.Clear();


            if (LE != null)
            {
                foreach (Etudient E in LE)
                    DG_Student.Rows.Add(E.num_Etud, E.nom, E.prenom, E.Groupe, E.tel, E.Genre, E.date_insc,E.date_PFE);
            }
        }


        // Bouton pour Enregistrer une nouvel Etudient dans la base de données

        private void btn_add_etu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Id_Etud.Text))
                MessageBox.Show("saisir L'Identifient de l'Etudient !");

            else
            {
                Etudient E = new Etudient
                {
                    num_Etud = Id_Etud.Text,
                    nom = nom_etud.Text,
                    prenom = pren_etud.Text,
                    Groupe = group_etud.Text,
                    tel = tel_etud.Text,
                    Genre = genre_etud.Text,
                    date_insc = dt_insc_etud.Text,
                    date_PFE = dt_Fin_Etud.Text,



                };
                Etudient E1 = EtudientADO.Recherche_Code(Id_Etud.Text);

                if (E1 == null)
                {
                    if (!Directory.Exists("imgStudent"))
                        Directory.CreateDirectory("imgStudent");
                    img_etud.Image.Save("imgStudent/" + Id_Etud.Text + ".jpg");


                 
                    EtudientADO.Ajouter(E);
                    Affiche_Etud();
                    img_etud.Image = new PictureBox().Image;

                }
                else
                    MessageBox.Show("Cet étudient existe dejà");
            }

        }

        // événement de chargement du formulaire FVoiture
        private void form_etud_Load(object sender, EventArgs e)

        {
            // TODO: cette ligne de code charge les données dans la table 'bDNoteDataSet.Etudients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            Affiche_Etud();

        }
        // événement qui se déclenche lors d'un double click sur une ligne du DataGridView
        //(sélection d'une voiture)
        private void DG_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int ind = DG_Student.CurrentRow.Index;
            Id_Etud.Text = DG_Student[0, ind].Value.ToString();
            nom_etud.Text = DG_Student[1, ind].Value.ToString();
            pren_etud.Text = DG_Student[2, ind].Value.ToString();
            group_etud.Text = DG_Student[3, ind].Value.ToString();
            tel_etud.Text = DG_Student[4, ind].Value.ToString();
            genre_etud.Text = DG_Student[5, ind].Value.ToString();
            dt_insc_etud.Text = DG_Student[6, ind].Value.ToString();
            dt_Fin_Etud.Text = DG_Student[7, ind].Value.ToString();

            string mypath = "imgStudent/" + DG_Student[0, ind].Value.ToString() + ".jpg";
            if (File.Exists(mypath))
                img_etud.Image = Image.FromFile(mypath);

        }
        // bouton pour supprimer une voiture sélectionnée

        private void btn_remv_etu_Click(object sender, EventArgs e)
        {

            //int ind = DG_Student.CurrentRow.Index;

            //string mypath = "imgStudent/" + DG_Student[0, ind].Value.ToString() + ".jpg";
            //if (File.Exists(mypath))
            //{
            //    File.Delete(mypath);
            //}
            EtudientADO.Supprimer(Id_Etud.Text);
            Affiche_Etud();

        }
        // bouton pour modifier une voiture sélectionnée

        private void btn_edit_etu_Click(object sender, EventArgs e)
        {

            Etudient E = new Etudient
            {
                num_Etud = Id_Etud.Text,
                nom = nom_etud.Text,
                prenom = pren_etud.Text,
                Groupe = group_etud.Text,
                tel = tel_etud.Text,
                Genre = genre_etud.Text,
                date_insc = dt_insc_etud.Text,
                date_PFE = dt_Fin_Etud.Text,


            };


           



                EtudientADO.Modifier(E);
            Affiche_Etud();
                img_etud.Image = new PictureBox().Image;
            
        }
        private void btn_del_etud_Click(object sender, EventArgs e)
        {
            Id_Etud.Text = ""; Id_Etud.Focus();

            nom_etud.Text = "";
            pren_etud.Text = "";
            group_etud.Text = "";
            tel_etud.Text = "";
            genre_etud.Text = "";
            dt_insc_etud.Text = "";
            dt_Fin_Etud.Text = "";
            img_etud.Image = new PictureBox().Image;


            Affiche_Etud();
        }
        // Bouton Recherche de voiture par Immatriculation ou par Marque

        private void btn_srch_etud_Click(object sender, EventArgs e)
        {

           
                if (!string.IsNullOrEmpty(Id_Etud.Text))
                {
                    Etudient E = EtudientADO.Recherche_Code(Id_Etud.Text);
                    if (E != null)
                    {
                    Id_Etud.Text = E.num_Etud;
                    nom_etud.Text = E.nom;
                    pren_etud.Text = E.prenom;
                    group_etud.Text = E.Groupe;
                    tel_etud.Text = E.tel;
                    genre_etud.Text = E.Genre;
                    dt_insc_etud.Text = E.date_insc;
                    dt_Fin_Etud.Text = E.date_PFE;
                   
                    int ind = DG_Student.CurrentRow.Index;

                    string mypath = "imgStudent/" + DG_Student[0, ind].Value.ToString() + ".jpg";
                    if (File.Exists(mypath))
                        img_etud.Image = Image.FromFile(mypath);

                    DG_Student.Rows.Clear();

                    DG_Student.Rows.Add(E.num_Etud, E.nom, E.prenom, E.Groupe, E.tel, E.Genre, E.date_insc, E.date_PFE);

                }
                else
                        MessageBox.Show("Aucune Etudient trouvée", "attention");
                }
                else
                if (!string.IsNullOrEmpty(nom_etud.Text))
                {
                    List<Etudient> l = EtudientADO.Recherche_Nom(nom_etud.Text);
                    if (l.Count > 0)
                    {
                        DG_Student.Rows.Clear();
                    foreach (var E in l)
                        DG_Student.Rows.Add(E.num_Etud, E.nom, E.prenom, E.Groupe, E.tel, E.Genre, E.date_insc, E.date_PFE) ;
                    }
                    else
                        MessageBox.Show("Aucune Etudient trouvée");
            }

        }

        private void btn_bro_etud_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            img_etud.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void btn_clse_etud_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
       
    }




