using System;
using System.Windows.Forms;


namespace Proget_Stage_Principame
{
    public partial class Imprimer : Form
    {
        public Imprimer()
        {
            InitializeComponent();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            DataSet1Report ds = new DataSet1Report();
            DataSet1ReportTableAdapters.ProspectTableAdapter imp = new DataSet1ReportTableAdapters.ProspectTableAdapter();
            imp.Fill(ds.Prospect);
            CrystalReportClient cr = new CrystalReportClient();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
