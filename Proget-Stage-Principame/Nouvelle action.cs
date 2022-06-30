using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class NouveauAct : Form
    {
        //Espace esp;

        public NouveauAct()
        {
            InitializeComponent();
            //this.esp = espaceName;
        }

        private void textCodProspect_TextChanged(object sender, EventArgs e)
        {
            if (textCodProspect.Text == " ")
            {
                Espace esp = new Espace();
                esp.Show();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nouvelle_action_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
