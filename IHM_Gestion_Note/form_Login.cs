using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM_Gestion_Note
{
    public partial class form_Login : MetroFramework.Forms.MetroForm
    {
        public form_Login()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Base_Note;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(s);
            if(con.State==ConnectionState.Closed)
            con.Open();
            string qry1 = "select count(*) from Enseignants where num_Ens = '" + txt_login.Text + "'and nom ='" + txt_pass.Text+"' ";
            string qry2 = "select count(*) from Etudients where num_Etud = '" + txt_login.Text + "'and nom ='" + txt_pass.Text + "' ";

            SqlCommand command1 = new SqlCommand(qry1, con);
            int result1 = Convert.ToInt32( command1.ExecuteScalar());
            SqlCommand command2 = new SqlCommand(qry2, con);
            int result2 = Convert.ToInt32(command2.ExecuteScalar());
            if (result1 > 0) 
            {
                form_Main_Prof frm = new form_Main_Prof();
                frm.ShowDialog();
                frm.Close();
                txt_login.Text = "";
                txt_pass.Text = "";
                txt_login.Focus();
            }
            if (result2 > 0)
            {
                form_etud frm = new form_etud();
                frm.ShowDialog();
                frm.Close();
                txt_login.Text = "";
                txt_pass.Text = "";
                txt_login.Focus();
            }
            else
                labelerror.Visible=true;
            if(con.State == ConnectionState.Open)
            con.Close();

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
