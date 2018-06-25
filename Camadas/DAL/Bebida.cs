using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_de_Pizzaria.Camadas.MODEL;

namespace Sistema_de_Pizzaria.Camadas.DAL
{
    public class Bebida
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Bebida> Select()
        {
            List<MODEL.Bebida> bebidas = new List<MODEL.Bebida>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Bebida";
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
                    MODEL.Bebida bebida = new MODEL.Bebida();

                    //"idCliente" "nome" etc é o nome no BD
                    bebida.IdBebida = Convert.ToInt32(reader["idBebida"].ToString());
                    bebida.Nome = reader["nome"].ToString();
                    bebida.Valor = Convert.ToSingle(reader["valor"].ToString());

                    //adiciona na lista enquanto tiver para ser adicionado
                    bebidas.Add(bebida);
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
            return bebidas;
        }

        //Insert no BD
        public void Insert(MODEL.Bebida bebida)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Bebida values(@nome, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", bebida.Nome);
            cmd.Parameters.AddWithValue("@valor", bebida.Valor);

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
        public void Update(MODEL.Bebida bebida)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Bebida set nome=@nome, valor=@valor where idBebida=@idBebida;";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idBebida", bebida.IdBebida);
            cmd.Parameters.AddWithValue("@nome", bebida.Nome);
            cmd.Parameters.AddWithValue("@valor", bebida.Valor);

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
            string sql = "Delete from Bebida where idBebida=@idBebida";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idBebida", id);

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
