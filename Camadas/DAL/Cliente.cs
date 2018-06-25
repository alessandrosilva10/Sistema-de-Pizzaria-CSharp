using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_Pizzaria.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> clientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
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
                    MODEL.Cliente cliente = new MODEL.Cliente();

                    //"idCliente" "nome" etc é o nome no BD
                    cliente.IdCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    cliente.Nome = reader["nome"].ToString();
                    cliente.Endereco = reader["endereco"].ToString();
                    cliente.Telefone = reader["telefone"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();

                    //adiciona na lista enquanto tiver para ser adicionado
                    clientes.Add(cliente);
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

            //Retorna a lista finalizada
            return clientes;
        }

        public List<MODEL.Cliente> Select(int idCliente)
        {
            List<MODEL.Cliente> clientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.IdCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    cliente.Nome = reader["nome"].ToString();
                    cliente.Telefone = reader["telefone"].ToString();
                    cliente.Endereco = reader["cidade"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();

                    clientes.Add(cliente);
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
            return clientes;
        }

        public List<MODEL.Cliente> Select(string nome)
        {
            List<MODEL.Cliente> clientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente  where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.IdCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    cliente.Nome = reader["nome"].ToString();
                    cliente.Telefone = reader["telefone"].ToString();
                    cliente.Endereco = reader["cidade"].ToString();
                    cliente.Cidade = reader["cidade"].ToString();

                    clientes.Add(cliente);
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

            return clientes;
        }


        //Insert no BD
        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values(@nome, @telefone, @endereco, @cidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);

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
        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, telefone=@telefone," +
                         " endereco=@endereco, cidade=@cidade where idCliente=@idCliente;";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);

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
            string sql = "Delete from Cliente where idCliente=@idCliente";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idCliente", id);

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
