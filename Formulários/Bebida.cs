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
    public partial class Bebida : Form
    {
        public Bebida()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtIdBebida.Text = "";
            txtNomeBebida.Text = "";
            txtValorBebida.Text = "";
            txtIdEditar.Text = "";
            txtNomeEditar.Text = "";
            txtValorEditar.Text = "";
            txtIdDeletar.Text = "";
        }

        private void Bebida_Load(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Bebida> lstBebida = new List<Camadas.MODEL.Bebida>();
            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();
            lstBebida = bllBebida.Select();

            dgvBebida.DataSource = lstBebida;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Bebida bebida = new Camadas.MODEL.Bebida();
            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();

            try
            {

                bebida.IdBebida = Int32.Parse(txtIdDeletar.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtIdDeletar.Text);

                    bllBebida.Delete(id);
                    MessageBox.Show("Exclusão realizada com Sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvBebida.DataSource = "";
                    dgvBebida.DataSource = bllBebida.Select();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Bebida bebida = new Camadas.MODEL.Bebida();
            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();

            if (MessageBox.Show("Deseja inserir o registro?", "Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {

                try
                {
                    bebida.Nome = txtNomeBebida.Text;
                    bebida.Valor = Convert.ToSingle(txtValorBebida.Text);

                    if (bebida.Valor > 0)
                    {
                        bllBebida.Insert(bebida);
                        dgvBebida.DataSource = "";
                        dgvBebida.DataSource = bllBebida.Select();
                        MessageBox.Show("Inserção realizada com sucesso :)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("`Valor não pode ser negativo :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Camadas.MODEL.Bebida bebida = new Camadas.MODEL.Bebida();
            Camadas.BLL.Bebida bllBebida = new Camadas.BLL.Bebida();

            try
            {
                if (MessageBox.Show("Deseja atualizar o registro?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    bebida.IdBebida = Convert.ToInt32(txtIdEditar.Text);
                    bebida.Nome = txtNomeEditar.Text;
                    bebida.Valor = Convert.ToSingle(txtValorEditar.Text);

                    bllBebida.Update(bebida);
                    MessageBox.Show("Atualização realizada com sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvBebida.DataSource = "";
                    dgvBebida.DataSource = bllBebida.Select();
                }
            }
            catch
            {
                MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                limparCampos();
            }

        }

        private void btnSairCadastroPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar a tela Principal?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();

                Principal principal = new Principal();
                principal.Visible = true;
            }
        }
    }
}
