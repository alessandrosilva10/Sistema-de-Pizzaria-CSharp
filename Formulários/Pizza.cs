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
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void Pizza_Load(object sender, EventArgs e)
        {
            //Pizzas Cadastradas no datagridview
            List<Camadas.MODEL.Pizza> lstPizza = new List<Camadas.MODEL.Pizza>();
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();
            lstPizza = bllPizza.Select();

            dgvPizza1.DataSource = lstPizza;
            
        }

        private void limparCampos()
        {
            txtIdDeletar.Text = "";
            txtIdPizza.Text = "";
            txtNomePizza.Text = "";
            txtValorPizza.Text = "";
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Pizza pizza = new Camadas.MODEL.Pizza();
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();

            if (MessageBox.Show("Deseja inserir o registro?", "Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
 
                  try
                  {
                    pizza.Nome = txtNomePizza.Text;
                    pizza.ValorBase = Convert.ToSingle(txtValorPizza.Text);

                    if (pizza.ValorBase > 0)
                    {
                        bllPizza.Insert(pizza);
                        dgvPizza1.DataSource = "";
                        dgvPizza1.DataSource = bllPizza.Select();
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

        private void btnSairCadastroPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Gostaria de voltar ao Menu Principal?", "Voltar ao Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
          
                Principal principal = new Principal();
                principal.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Pizza pizza = new Camadas.MODEL.Pizza();
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();

            try
            {
                if (MessageBox.Show("Deseja atualizar o registro?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    pizza.IdPizza = Convert.ToInt32(txtIdEditar.Text);
                    pizza.Nome = txTipoEditar.Text;
                    pizza.ValorBase = Convert.ToSingle(txtValorEditar.Text);

                    bllPizza.Update(pizza);
                    MessageBox.Show("Atualização realizada com sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvPizza1.DataSource = "";
                    dgvPizza1.DataSource = bllPizza.Select();
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Pizza pizza = new Camadas.MODEL.Pizza();
            Camadas.BLL.Pizza bllPizza = new Camadas.BLL.Pizza();

            try
            {

                if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        int id = Convert.ToInt32(txtIdDeletar.Text);

                        bllPizza.Delete(id);
                        MessageBox.Show("O registro foi deletado com sucesso :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPizza1.DataSource = "";
                        dgvPizza1.DataSource = bllPizza.Select();      
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

        private void lblNomePizza_Click(object sender, EventArgs e)
        {

        }

        private void txtIdPizza_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCadastroPizzas_Enter(object sender, EventArgs e)
        {

        }
    }
}
