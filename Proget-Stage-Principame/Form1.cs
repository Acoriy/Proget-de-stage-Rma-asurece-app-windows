using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //panel1.Size = new System.Drawing.Size(346, 660);
        }

        public void loadform(object Form)
        {
            if (this.mainepanel.Controls.Count > 0)
                this.mainepanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainepanel.Controls.Add(f);
            this.mainepanel.Tag = f;
            f.Show();
        }
        private void btnlisteProcpect_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnlisteProcpect.Top;
            loadform(new MenuMesAjour());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnListeAction.Top;
            loadform(new Listeaction());
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PetiMenu_Click(object sender, EventArgs e)
        {

            //if (panel1.Size == new System.Drawing.Size(346, 660))
            //{
            //    panel1.Size = new System.Drawing.Size(112, 660);
            //}
            //else
            //{
            //    panel1.Size = new System.Drawing.Size(346, 660);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlBut.Top = btnEcheancier.Top;
        }
    }
}
