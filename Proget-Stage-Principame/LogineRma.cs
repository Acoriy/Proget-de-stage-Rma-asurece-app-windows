using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class LogineRma : Form
    {
        public LogineRma()
        {
            InitializeComponent();
        }
        prospectEnty pro = new prospectEnty();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var result = pro.Logines.Where(p => p.Uname == textUName.Text && p.passworde == textPassword.Text).ToList();
            //if (result.Count() > 0)
            //{
            //    this.Close();

            //    Thread th = new Thread(ope)
            //}
            //try
            //{
            //    if (pro.Logines.Where(p => p.Uname == textUName.Text && p.passworde == textPassword.Text).Count() > 0)
            //    {
            //        MessageBox.Show("Valide User ");
            //    }
            //    else
            //    {
            //        MessageBox.Show("invalide user ");
            //    }
            //}
            //catch(Exception ert)
            //{

            //}
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-4H4BT27;Initial Catalog=Proget_stage;Integrated Security=True");
            string query = "select * from Logine where Uname ='" + comboBox1.Text.Trim() + "' and  passworde = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cnx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MenuPremier f = new MenuPremier();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("the password is incorrect :( !!! ", "Erour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
