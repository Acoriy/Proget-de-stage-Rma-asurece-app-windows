using System;
using System.Windows.Forms;

namespace Proget_Stage_Principame
{
    public partial class AfficherGraph1 : Form
    {
        public AfficherGraph1()
        {
            InitializeComponent();
        }

        private void AfficherGraph1_Load(object sender, EventArgs e)
        {
            DataSet1Report ds = new DataSet1Report();
            DataSet1ReportTableAdapters.ProspectTableAdapter pro = new DataSet1ReportTableAdapters.ProspectTableAdapter();
            pro.Fill(ds.Prospect);
            CrystalReportGraph1 cr = new CrystalReportGraph1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
