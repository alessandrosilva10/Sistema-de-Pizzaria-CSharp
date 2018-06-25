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
    public partial class RelatorioPedido : Form
    {
        public RelatorioPedido()
        {
            InitializeComponent();
        }

        private void RelatorioPedido_Load(object sender, EventArgs e)
        {

        }

        private void crvPedido_Load(object sender, EventArgs e)
        {
            Relatórios.PedidoRelatorio pedidor = new Relatórios.PedidoRelatorio();
            crvPedido.ReportSource = pedidor;
        }
    }
}
