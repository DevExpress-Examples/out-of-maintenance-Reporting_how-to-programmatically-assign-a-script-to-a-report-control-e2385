using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new ReportPrintTool(CreateReport()).ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            new ReportDesignTool(CreateReport()).ShowDesignerDialog();
        }

        private XtraReport CreateReport() {
            // Create a new report.
            XtraReport1 report = new XtraReport1();

            // Add a script to a report's collection of scripts.
            report.ScriptsSource += "private void xrLabel1_BeforePrint(object sender, " +
                                    "System.Drawing.Printing.PrintEventArgs e) {\r\n  " +
                                    "((XRLabel)sender).BackColor = Color.Aqua;\r\n}";

            // Assign this script to a label's BeforePrint script.
            report.xrLabel1.Scripts.OnBeforePrint = "xrLabel1_BeforePrint";

            return report;
        }
    }
}