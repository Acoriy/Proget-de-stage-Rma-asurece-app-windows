using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class MenuPremier : Form
    {
        public MenuPremier()
        {
            InitializeComponent();
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Menuextirieure_Load(object sender, EventArgs e)
        {

        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            //AfficherGraph grap = new AfficherGraph();
            //grap.Show();
            this.Close();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatistiques_Click_1(object sender, EventArgs e)
        {
            choiGraph grph = new choiGraph();
            grph.Show();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnProduction_Click_1(object sender, EventArgs e)
        {

        }

        private void btnContabilite_Click(object sender, EventArgs e)
        {

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }

        private void btnDossierS_Click(object sender, EventArgs e)
        {

        }

        private void btnProspection_Click(object sender, EventArgs e)
        {

        }

        private void btnOutils_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
