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
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtPesquisaPizza.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Bebida> listaBebida = new List<Camadas.MODEL.Bebida>();
            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();

            if (cbBebidas.Text == "Todos")
            {
                dgvPesquisa.DataSource = "";
                dgvPesquisa.DataSource = bllBebida.Select();
            }

        }

 

        private void rbTodosPizza_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisaPizza.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();
            dgvPesquisa.DataSource = "";
            dgvPesquisa.DataSource = bllPizza.Select();
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisaPizza.Visible = false;
            btnFiltrar.Visible = false;

            lblPesquisaBebida.Visible = false;

            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();
            dgvPesquisa.DataSource = "";
            dgvPesquisa.DataSource = bllPizza.Select();
        }

        private void rbIdPizza_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisaPizza.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisaPizza.Focus();
        }

        private void lblPesquisa_Click(object sender, EventArgs e)
        {


        }

        private void txtPesquisaPizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNomePizza_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisaPizza.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisaPizza.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            List<Camadas.MODEL.Pizza> listaPizza = new List<Camadas.MODEL.Pizza>();
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();

            if (rbIdPizza.Checked)
            {
                if(txtPesquisaPizza.Text != string.Empty)
                {
                    listaPizza = bllPizza.Select(Convert.ToInt32(txtPesquisaPizza.Text));
                }
                else
                {
                    MessageBox.Show("Erro: ID Vazio :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (rbNomePizza.Checked)
            {
                if (txtPesquisaPizza.Text != string.Empty)
                {
                    listaPizza = bllPizza.Select(txtPesquisaPizza.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Erro: Nome Vazio :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dgvPesquisa.DataSource = "";
            dgvPesquisa.DataSource = listaPizza;
            limparCampos();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();

            dgvPesquisa.DataSource = "";
            dgvPesquisa.DataSource = bllBebida.Select();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Gostaria de voltar ao Menu Principal?", "Voltar ao Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();

                Principal principal = new Principal();
                principal.Visible = true;
            }
        }
    }
}
