using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.DAL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=ALESSANDRO10-PC\SQLEXPRESS;Initial Catalog=PizzariaBD;Integrated Security=True";
        }
    }
}
