using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class Ajoute : Form
    {
        public Ajoute()
        {
            InitializeComponent();
        }
        prospectEnty pro = new prospectEnty();
        private void Ajoute_Load(object sender, EventArgs e)
        {

        }
        public void ClearChamp()
        {
            textNom.Text = "";
            textEmail.Text = "";
            textaddres.Text = "";
            textTel.Text = "";
            textVille.Text = "";
            textObservation.Text = "";
            dateTimePickerDC.Value = DateTime.Now;
            comboBranche.SelectedIndex = -1;
            comboDemarcheur.SelectedIndex = -1;
            comboProfessio_activité.SelectedIndex = -1;
            comboTitre.SelectedIndex = -1;
            maskedTextDate.Text = "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            prospectEnty pro = new prospectEnty();
            Prospect pr = new Prospect();
            pr.Nom = textNom.Text;
            //pr.date_creation = maskedTextDate.Text.ToString();
            pr.date_creation = dateTimePickerDC.Value;
            pr.Titre = comboTitre.Text;
            pr.Branche = comboBranche.Text;
            pr.Demarcheure = comboDemarcheur.Text;
            pr.Adresse = textaddres.Text;
            pr.Observation = textObservation.Text;
            pr.ville = textVille.Text;
            pr.Telephone = textTel.Text;
            pr.Profession_Activité = comboProfessio_activité.Text;
            pr.email = textEmail.Text;
            pro.Prospects.Add(pr);
            pro.SaveChanges();
            MessageBox.Show("Bien Ajouter :)", "Tré bient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearChamp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
