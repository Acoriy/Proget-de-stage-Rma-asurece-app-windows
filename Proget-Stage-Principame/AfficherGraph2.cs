using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class AfficherGraph2 : Form
    {
        public AfficherGraph2()
        {
            InitializeComponent();
        }

        private void AfficherGraph2_Load(object sender, EventArgs e)
        {
            DataSet1Report ds = new DataSet1Report();
            DataSet1ReportTableAdapters.ProspectTableAdapter pros = new DataSet1ReportTableAdapters.ProspectTableAdapter();
            pros.Fill(ds.Prospect);
            CrystalReportGraph2 cr = new CrystalReportGraph2();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
