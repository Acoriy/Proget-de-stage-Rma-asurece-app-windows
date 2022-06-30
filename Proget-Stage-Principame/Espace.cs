using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Proget_Stage_Principame
{
    public partial class Espace : Form
    {
        public Espace()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-4H4BT27;Initial Catalog=Proget_stage;Integrated Security=True");
        prospectEnty pro = new prospectEnty();
        List<Prospect> listClient = new List<Prospect>();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();

        public void Designegrid()
        {
            dataGridEspace.BorderStyle = BorderStyle.None;
            dataGridEspace.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridEspace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridEspace.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 48, 80);
            dataGridEspace.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridEspace.BackgroundColor = Color.White;

            dataGridEspace.EnableHeadersVisualStyles = false;
            dataGridEspace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridEspace.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridEspace.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void Espace_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1Report.Prospect'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.prospectTableAdapter.Fill(this.dataSet1Report.Prospect);
            listClient = pro.Prospects.ToList();
            Designegrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajoute aj = new Ajoute();
            aj.Show();
        }

        private void textRechercheEsp_TextChanged(object sender, EventArgs e)
        {
            prospectBindingSource1.DataSource = pro.Prospects.Where(p => p.Nom.Contains(textRechercheEsp.Text)).ToList();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Prospect pr = new Prospect();
            //NouveauAct nvou = new NouveauAct(this);
            //nvou.ShowDialog();
            ////////da = new SqlDataAdapter("select * from Prospect where code =  " + dataGridEspace.SelectedRows[0].Cells[0].Value.ToString() + "", cnx);
            ////////da.Fill(dt);
            //////Prospect pr = new Prospect();
            ////dataGridEspace.Rows(dataGridEspace.SelectedRows[0].Index);
            //////nouvelle_action.$
            //int code = Convert.ToInt32(nvou.textCodProspect.Text);
            //nvou.labelclient.Text = pr.Nom;
            //code = pr.code;
            //nvou.textDemarcheur.Text = pr.Demarcheure;
            this.Close();

        }

        private void dataGridEspace_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEspace_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NouveauAct nv = new NouveauAct();
            nv.textCodProspect.Text = this.dataGridEspace.CurrentRow.Cells[0].Value.ToString();
            nv.labelclient.Text = this.dataGridEspace.CurrentRow.Cells[1].Value.ToString();
            nv.textSonTel.Text = this.dataGridEspace.CurrentRow.Cells[2].Value.ToString();
            nv.textDemarcheur.Text = this.dataGridEspace.CurrentRow.Cells[3].Value.ToString();
            nv.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridEspace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
