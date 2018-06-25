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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            //Pedidos Cadastrados 
            List<Camadas.MODEL.Pedido> lstPedido = new List<Camadas.MODEL.Pedido>();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
            lstPedido = bllPedido.Select();

            dgvPedido.DataSource = lstPedido;
        
        }

        public void limparDados()
        {
            txtIdPedido.Text = "";
            txtIdPizza.Text = "";
            txtIdBebida.Text = "";
            txtIdCliente.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            mtbData.Text = "";
            txtObs.Text = "";
            txtIdDeletar.Text = "";
            txtIdPedidoEditar.Text = "";
            txtIdClienteEditar.Text = "";
            txtIdBebidaEditar.Text = "";
            txtIdPizzaEditar.Text = "";
            txtIdValorEditar.Text = "";
            txtQuantidadeEditar.Text = "";
            txtObsEditar.Text = "";
            txtDataEditar.Text = "";        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar a tela Principal?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();

                Principal principal = new Principal();
                principal.Visible = true;
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {

            Camadas.MODEL.Pedido pedido = new Camadas.MODEL.Pedido();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();

            if (MessageBox.Show("Deseja inserir o registro?", "Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {

                try
                {
                    pedido.idPizza = Int32.Parse(txtIdPizza.Text);
                    pedido.idCliente = Int32.Parse(txtIdCliente.Text);
                    pedido.idBebida = Int32.Parse(txtIdBebida.Text);
                    pedido.valor = Int32.Parse(txtValor.Text);
                    pedido.quantidade = Int32.Parse(txtQuantidade.Text);
                    pedido.data = DateTime.Parse(mtbData.Text);
                    pedido.observacao = txtObs.Text;

                    if (pedido.valor > 0)
                    {

                        bllPedido.Insert(pedido);
                        MessageBox.Show("Inserção realizada com sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvPedido.DataSource = "";
                        dgvPedido.DataSource = bllPedido.Select();
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
                    limparDados();
                }


            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Camadas.MODEL.Pedido pedido = new Camadas.MODEL.Pedido();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();

            try
            {
                if (MessageBox.Show("Deseja atualizar o registro?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    pedido.idPedido = Convert.ToInt32(txtIdPedidoEditar.Text);
                    pedido.idPizza = Convert.ToInt32(txtIdPizzaEditar.Text);
                    pedido.idBebida = Convert.ToInt32(txtIdBebidaEditar.Text);
                    pedido.idCliente = Convert.ToInt32(txtIdClienteEditar.Text);
                    pedido.valor = Convert.ToSingle(txtIdValorEditar.Text);
                    pedido.quantidade = Convert.ToInt32(txtQuantidadeEditar.Text);
                    pedido.data = Convert.ToDateTime(txtDataEditar.Text);
                    pedido.observacao = txtObsEditar.Text;

                    bllPedido.Update(pedido);
                    MessageBox.Show("Atualização realizada com sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvPedido.DataSource = "";
                    dgvPedido.DataSource = bllPedido.Select();
                }
            }
            catch
            {
                MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                limparDados();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Pedido pedido = new Camadas.MODEL.Pedido();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();

            try
            { 

                pedido.idPedido = Int32.Parse(txtIdDeletar.Text);

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                        int id = Convert.ToInt32(txtIdDeletar.Text);
                        int index = Convert.ToInt32(bllPedido.Select());

                        bllPedido.Delete(id);

                        MessageBox.Show("Exclusão realizada com Sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvPedido.DataSource = "";
                        dgvPedido.DataSource = bllPedido.Select();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Você inseriu um caracter em um campo que só aceita inteiros :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limparDados();
            }
        }
    }
}
