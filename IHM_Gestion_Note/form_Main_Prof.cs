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
    public partial class form_Main_Prof : MetroFramework.Forms.MetroForm
    {
        public form_Main_Prof()
        {
            InitializeComponent();
        }

        private void btn_manage_prof_Click(object sender, EventArgs e)
        {
            form_enseg frm1 = new form_enseg();
            frm1.ShowDialog();
        }

        private void btn_manage_note_Click(object sender, EventArgs e)
        {
            form_module frm2 = new form_module();
            frm2.ShowDialog();
        }

        private void btn_manage_student_Click(object sender, EventArgs e)
        {
            form_etud frm = new form_etud();
            frm.ShowDialog();
        }

        private void btn_manage_abs_Click(object sender, EventArgs e)
        {
            form_absance frm = new form_absance();
            frm.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
