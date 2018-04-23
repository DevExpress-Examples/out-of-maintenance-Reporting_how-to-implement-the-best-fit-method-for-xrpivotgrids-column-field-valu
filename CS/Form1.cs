using System;
using System.Windows.Forms;
// ...

namespace RepPGVertHeadersHeight {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            pivotGridControl1.Fields["MyRow"].BestFit();
        }

        private void button2_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            //new DevExpress.XtraReports.UI.ReportDesignTool(report).ShowDesignerDialog();
            new DevExpress.XtraReports.UI.ReportPrintTool(report).ShowPreviewDialog();
        }
    }
}