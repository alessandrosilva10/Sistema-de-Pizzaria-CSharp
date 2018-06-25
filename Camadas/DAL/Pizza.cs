using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sistema_de_Pizzaria.Camadas.MODEL;

namespace Sistema_de_Pizzaria.Camadas.DAL
{
    public class Pizza
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Pizza> Select()
        {
            List<MODEL.Pizza> pizzas = new List<MODEL.Pizza>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pizza";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                //Abre a conexão
                conexao.Open();
                //Irá executar o comando
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                //Lê no BD
                while (reader.Read())
                {
                    //Instancia o Objeto
                    MODEL.Pizza pizza = new MODEL.Pizza();

                    //"idCliente" "nome" etc é o nome no BD
                    pizza.IdPizza = Convert.ToInt32(reader["idPizza"].ToString());
                    pizza.Nome = reader["nome"].ToString();
                    pizza.ValorBase = Convert.ToSingle(reader["valorBase"].ToString());

                    //adiciona na lista enquanto tiver para ser adicionado
                    pizzas.Add(pizza);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao consultar o Cliente");
            }
            finally
            {
                conexao.Close();
            }

            return pizzas;
        }

        public List<MODEL.Pizza> Select(int idPizza)
        {
            List<MODEL.Pizza> pizzas = new List<MODEL.Pizza>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pizza where idPizza=@idPizza;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPizza", idPizza);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pizza pizza = new MODEL.Pizza();
                    pizza.IdPizza = Convert.ToInt32(reader["idPizza"].ToString());
                    pizza.Nome = reader["nome"].ToString(); 
                    pizza.ValorBase = Convert.ToSingle(reader["valorBase"].ToString());

                    pizzas.Add(pizza);
                }
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na consulta por ID");
            }
            finally
            {
                conexao.Close();
            }
            return pizzas; 
        }

        public List<MODEL.Pizza> Select(string nome)
        {
            List<MODEL.Pizza> pizzas = new List<MODEL.Pizza>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pizza  where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pizza pizza = new MODEL.Pizza();
                    pizza.IdPizza = Convert.ToInt32(reader["idPizza"].ToString());
                    pizza.Nome = reader["nome"].ToString();
                    pizza.ValorBase = Convert.ToSingle(reader["valorBase"].ToString());
                    pizzas.Add(pizza);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Produto Por ID");
            }
            finally
            {
                conexao.Close();
            }
            return pizzas; 
        }


        //Insert no BD
        public void Insert(MODEL.Pizza pizza)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Pizza values(@nome, @valorBase);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", pizza.Nome);
            cmd.Parameters.AddWithValue("@valorBase", pizza.ValorBase);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na Inserção dos dados");
            }
            finally
            {
                conexao.Close();
            }
        }

            //Update no BD
            public void Update(MODEL.Pizza pizza)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Update Pizza set nome=@nome, valorBase=@valorBase where idPizza=@idPizza;";

                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idPizza", pizza.IdPizza);
                cmd.Parameters.AddWithValue("@nome", pizza.Nome);
                cmd.Parameters.AddWithValue("@valorBase", pizza.ValorBase);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na Atualização dos dados");

            }
            finally
            {
                conexao.Close();
            }
            }


        //Delete no BD
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Pizza where idPizza=@idPizza";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idPizza", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na Remoção dos dados");
            }
            finally
            {
                conexao.Close();
            }

            }
        }
    }
