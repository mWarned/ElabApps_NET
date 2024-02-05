using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "C:\\GitHub\\ElabApps_NET\\lab2Report\\lab2Report\\report.rdl";

            //reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.RefreshReport();
        }
    }
}
