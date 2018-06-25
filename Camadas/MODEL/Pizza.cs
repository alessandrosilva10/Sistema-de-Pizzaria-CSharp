using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.MODEL
{
    public class Pizza
    {
        private int idPizza;
        private string nome;
        private float valorBase;

        public int IdPizza { get => idPizza; set => idPizza = value; }
        public string Nome { get => nome; set => nome = value; }
        public float ValorBase { get => valorBase; set => valorBase = value; }
    }
}
