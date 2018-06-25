using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pizzaria
{
    public partial class RelatorioBebida : Form
    {
        public RelatorioBebida()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Relatórios.BebidaRelatorio bebidar = new Relatórios.BebidaRelatorio();
            crvBebida.ReportSource = bebidar;
        }
    }
}
