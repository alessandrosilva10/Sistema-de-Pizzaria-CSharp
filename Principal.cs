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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();      
        }

        private void Principal_Load(object sender, EventArgs e)
        {
   
                
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do Programa?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            this.Hide();
            cliente.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            this.Hide();
            pedido.ShowDialog();
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            this.Hide();
            pizza.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bebida bebida = new Bebida();
            bebida.ShowDialog(this);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();
            this.Hide();
            pesquisa.Show();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            this.Hide();
            pedido.Show();
        }

        private void pizzasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioPizza relatoriop = new RelatorioPizza();
            relatoriop.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente cliente = new frmRelatorioCliente();
            cliente.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioPedido pedidor = new RelatorioPedido();
            pedidor.Show();
        }

        private void bebidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioBebida bebidar = new RelatorioBebida();
            bebidar.Show();
        }
    }
}
