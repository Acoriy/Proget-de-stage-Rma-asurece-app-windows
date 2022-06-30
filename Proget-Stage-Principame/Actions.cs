using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class Listeaction : Form
    {
        public Listeaction()
        {
            InitializeComponent();
        }
        prospectEnty pro = new prospectEnty();

        public void Designegrid()
        {
            dataGridAction.BorderStyle = BorderStyle.None;
            dataGridAction.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridAction.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridAction.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 48, 80);
            dataGridAction.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridAction.BackgroundColor = Color.White;

            dataGridAction.EnableHeadersVisualStyles = false;
            dataGridAction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridAction.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridAction.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'proget_stageDataSet.LActionProspection'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.lActionProspectionTableAdapter.Fill(this.proget_stageDataSet.LActionProspection);
            dataGridAction.DataSource = pro.ListeAction();
            Designegrid();
        }

        private void btnNvAction_Click(object sender, EventArgs e)
        {
            NouveauAct nv = new NouveauAct();
            nv.Show();
        }
    }
}