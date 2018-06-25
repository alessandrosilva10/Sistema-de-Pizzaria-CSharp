using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_Pizzaria.Camadas.DAL
{
    public class Pedido
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Pedido> Select()
        {
            List<MODEL.Pedido> pedidos = new List<MODEL.Pedido>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pedido";
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
                    MODEL.Pedido pedido = new MODEL.Pedido();

                    //"idCliente" "nome" etc é o nome no BD
                    pedido.idPedido = Convert.ToInt32(reader["idPedido"].ToString());
                    pedido.idPizza = Convert.ToInt32(reader["idPizza"].ToString());
                    pedido.idBebida = Convert.ToInt32(reader["idBebida"].ToString());
                    pedido.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    pedido.valor = Convert.ToSingle(reader["valor"].ToString());
                    pedido.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    pedido.data = Convert.ToDateTime(reader["data"].ToString());
                    pedido.observacao = reader["observacao"].ToString();

                    //adiciona na lista enquanto tiver para ser adicionado
                    pedidos.Add(pedido);
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

            return pedidos;
        }

        public List<MODEL.Pedido> SelectId(int idPedido)
        {
            List<MODEL.Pedido> pedidos = new List<MODEL.Pedido>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pedido where idPedido=@idPedido;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPedido", idPedido);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pedido pedido = new MODEL.Pedido();
                    pedido.idPedido = Convert.ToInt32(reader["idPedido"].ToString());
                    pedido.idPizza = Convert.ToInt32(reader["idPizza"].ToString());
                    pedido.idBebida = Convert.ToInt32(reader["idBebida"].ToString());
                    pedido.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                    pedido.valor = Convert.ToSingle(reader["valor"].ToString());
                    pedido.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    pedido.data = Convert.ToDateTime(reader["data"].ToString());
                    pedido.observacao = reader["observacao"].ToString();

                    pedidos.Add(pedido);
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
            return pedidos;
        }

        //Insert no BD
        public void Insert(MODEL.Pedido pedido)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Pedido values(@idPizza, @idBebida, @idCliente, @valor, @quantidade, @data, @observacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idPizza", pedido.idPizza);
            cmd.Parameters.AddWithValue("@idBebida", pedido.idBebida);
            cmd.Parameters.AddWithValue("@idCliente", pedido.idCliente);
            cmd.Parameters.AddWithValue("@valor", pedido.valor);
            cmd.Parameters.AddWithValue("@quantidade", pedido.quantidade);
            cmd.Parameters.AddWithValue("@data", pedido.data);
            cmd.Parameters.AddWithValue("@observacao", pedido.observacao);

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
        public void Update(MODEL.Pedido pedido)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Pedido set idPizza=@idPizza, idBebida=@idBebida, idCliente=@idCliente, valor=@valor, quantidade=@quantidade, data=@data, observacao=@observacao where idPedido=@idPedido;";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idPedido", pedido.idPedido);
            cmd.Parameters.AddWithValue("@idPizza", pedido.idPizza);
            cmd.Parameters.AddWithValue("@idBebida", pedido.idBebida);
            cmd.Parameters.AddWithValue("@idCliente", pedido.idCliente);
            cmd.Parameters.AddWithValue("@valor", pedido.valor);
            cmd.Parameters.AddWithValue("@quantidade", pedido.quantidade);
            cmd.Parameters.AddWithValue("@data", pedido.data);
            cmd.Parameters.AddWithValue("@observacao", pedido.observacao);

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
            string sql = "Delete from Pedido where idPedido=@idPedido";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idPedido", id);

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
