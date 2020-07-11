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
    public partial class form_absance : MetroFramework.Forms.MetroForm
    {
        public form_absance()
        {
            InitializeComponent();
        }

        private void btn_add_Abs_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Id_abs.Text))
                MessageBox.Show("saisir L'Identifient de l'Ensignant !");

            else
            {
                Absance E = new Absance
                {
                    Num_Abs = Id_abs.Text,
                    num_Etud = id_Etudient.Text,
                    dateabs = date_abs.Text,
                    absTP = abs_TP.Text,
                    absCours = abs_Cours.Text,
                    


                };
            //    Enseignant E1 = AbsanceADO.Recherche_Code(Id_abs.Text);

            //    if (E1 == null)
            //    {
            //        if (!Directory.Exists("img"))
            //            Directory.CreateDirectory("img");
            //        img_ens.Image.Save("img/" + Id_Ens.Text + ".jpg");


            //        EnseignantADO.Ajouter(E);
            //        Affiche_Ens();

            //        img_ens.Image = new PictureBox().Image;

            //    }
            //    else
            //        MessageBox.Show("Cet enseignant existe dejà");
            //}
        }

    }
}
}
