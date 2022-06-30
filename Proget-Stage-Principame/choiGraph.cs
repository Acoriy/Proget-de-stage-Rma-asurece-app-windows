using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class choiGraph : Form
    {
        public choiGraph()
        {
            InitializeComponent();
        }

        private void GraphClient_Click(object sender, EventArgs e)
        {
            AfficherGraph1 af = new AfficherGraph1();
            af.Show();
        }

        private void GraphEmploiyés_Click(object sender, EventArgs e)
        {
            AfficherGraph2 af2 = new AfficherGraph2();
            af2.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
