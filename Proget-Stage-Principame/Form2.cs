using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class MenuMesAjour : Form
    {
        public MenuMesAjour()
        {
            InitializeComponent();
        }
        prospectEnty pro = new prospectEnty();
        List<Prospect> listClient = new List<Prospect>();
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-4H4BT27;Initial Catalog=Proget_stage;Integrated Security=True");
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Ajoute aj = new Ajoute();
            aj.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier mod = new Modifier();
            mod.Show();
        }
        public void Designegrid()
        {
            dataGridViewClient.BorderStyle = BorderStyle.None;
            dataGridViewClient.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewClient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClient.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 48, 80);
            dataGridViewClient.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewClient.BackgroundColor = Color.White;

            dataGridViewClient.EnableHeadersVisualStyles = false;
            dataGridViewClient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewClient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void MenuMesAjour_Load(object sender, EventArgs e)
        {
            prospectBindingSource.DataSource = pro.Prospects.ToList();
            listClient = pro.Prospects.ToList();
            Designegrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imprimer im = new Imprimer();
            im.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textRechercher_TextChanged(object sender, EventArgs e)
        {
            prospectBindingSource.DataSource = pro.Prospects.Where(pr => pr.Nom.Contains(textRechercher.Text)).ToList();
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridViewClient.CurrentCell.RowIndex;
            //dataGridViewClient.Rows.RemoveAt(rowIndex);
            //MessageBox.Show("bien suprimer ");
            //MessageBox.Show("Etes-vous sur de suprimer ce client ", "Virification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            cnx.Open();
            SqlCommand cmd = new SqlCommand("delete from Prospect where code =  " + dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString() + "", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Etes-vous sur de suprimer ce client ", "Virification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            dataGridViewClient.Rows.RemoveAt(dataGridViewClient.SelectedRows[0].Index);
            cnx.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
