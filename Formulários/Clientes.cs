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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void limparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";

            txtIdDeletar.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Cliente> lstCliente = new List<Camadas.MODEL.Cliente>();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            lstCliente = bllCliente.Select();

            dataGridView1.DataSource = lstCliente;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

            if (MessageBox.Show("Deseja inserir o registro?", "Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    cliente.Nome = txtNome.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Cidade = txtCidade.Text;

                    if (cliente.Nome != "")
                    {
                        bllCliente.Insert(cliente);
                        MessageBox.Show("Inserção realizada com Sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = "";
                        dataGridView1.DataSource = bllCliente.Select();
                    }
                    else
                    {
                        MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (FormatException)
                {
                    MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    limparCampos();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

            try
            {
                cliente.IdCliente = Int32.Parse(txtId.Text);
                
                if (MessageBox.Show("Deseja atualizar o registro?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    if (txtId.Text == "")
                    {
                        MessageBox.Show("Erro ao Atualizar o registro pois o ID não pode estar vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cliente.IdCliente = Convert.ToInt32(txtId.Text);
                        cliente.Nome = txtNome.Text;
                        cliente.Telefone = txtTelefone.Text;
                        cliente.Endereco = txtEndereco.Text;
                        cliente.Cidade = txtCidade.Text;

                        bllCliente.Update(cliente);

                        MessageBox.Show("Atualização realizada com Sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = "";
                        dataGridView1.DataSource = bllCliente.Select();
                    }

                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limparCampos();
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

            try
            {

                cliente.IdCliente = Int32.Parse(txtIdDeletar.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                        int id = Convert.ToInt32(txtIdDeletar.Text);

                        bllCliente.Delete(id);
                        MessageBox.Show("Exclusão realizada com Sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = "";
                        dataGridView1.DataSource = bllCliente.Select();        
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limparCampos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja voltar a tela Principal?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();

                Principal principal = new Principal();
                principal.Visible = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
