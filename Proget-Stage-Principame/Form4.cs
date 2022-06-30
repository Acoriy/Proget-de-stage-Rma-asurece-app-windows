using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }
        prospectEnty pro = new prospectEnty();
        List<Prospect> listClient = new List<Prospect>();
        Prospect pr = new Prospect();
        int indice;

        public void Designegrid()
        {
            dataGridModifier.BorderStyle = BorderStyle.None;
            dataGridModifier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridModifier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridModifier.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 48, 80);
            dataGridModifier.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridModifier.BackgroundColor = Color.White;

            dataGridModifier.EnableHeadersVisualStyles = false;
            dataGridModifier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridModifier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridModifier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            prospectBindingSource.DataSource = pro.Prospects.ToList();
            listClient = pro.Prospects.ToList();
            indice = 0;
            Designegrid();
        }

        private void btnOKModifier_Click(object sender, EventArgs e)
        {
            //listClient[indice].Nom = textNom.Text;
            //listClient[indice].date_creation =dateTimePicker1.Value;
            //listClient[indice].Titre = comboTitre.Text;
            //listClient[indice].Branche = comboBranche.Text;
            //listClient[indice].Demarcheure = comboDemarcheur.Text;
            //listClient[indice].Adresse = textAddress.Text;
            //listClient[indice].Observation = textObservation.Text;
            //listClient[indice].ville = textVille.Text;
            //listClient[indice].Telephone = textTel.Text;
            //listClient[indice].Profession_Activité = comboProfessio_activité.Text;
            //listClient[indice].email = textEmail.Text;
            int cd = Convert.ToInt32(textCode.Text);
            Prospect pr = (from p in pro.Prospects where p.code == cd select p).FirstOrDefault();
            pr.code = cd;
            pr.Nom = textNom.Text;
            pr.date_creation = dateTimePicker1.Value;
            pr.Titre = comboTitre.Text;
            pr.Branche = comboBranche.Text;
            pr.Demarcheure = comboDemarcheur.Text;
            pr.Adresse = textAddress.Text;
            pr.Observation = textObservation.Text;
            pr.ville = textVille.Text;
            pr.Telephone = textTel.Text;
            pr.Profession_Activité = comboProfessio_activité.Text;
            pr.email = textEmail.Text;
            pro.SaveChanges();
            MessageBox.Show("Bien Modifier :) ", "treé bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textRechercher_TextChanged(object sender, EventArgs e)
        {
            prospectBindingSource.DataSource = pro.Prospects.Where(pr => pr.Nom.Contains(textRechercher.Text)).ToList();

        }

        private void dataGridModifier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCode.Text = dataGridModifier.Rows[e.RowIndex].Cells[0].Value.ToString();
            textNom.Text = dataGridModifier.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridModifier.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboTitre.Text = dataGridModifier.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBranche.Text = dataGridModifier.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboDemarcheur.Text = dataGridModifier.Rows[e.RowIndex].Cells[5].Value.ToString();
            textAddress.Text = dataGridModifier.Rows[e.RowIndex].Cells[6].Value.ToString();
            textObservation.Text = dataGridModifier.Rows[e.RowIndex].Cells[7].Value.ToString();
            textVille.Text = dataGridModifier.Rows[e.RowIndex].Cells[8].Value.ToString();
            textTel.Text = dataGridModifier.Rows[e.RowIndex].Cells[9].Value.ToString();
            comboProfessio_activité.Text = dataGridModifier.Rows[e.RowIndex].Cells[10].Value.ToString();
            textEmail.Text = dataGridModifier.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
