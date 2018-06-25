using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.MODEL
{
    public class Bebida
    {
        private int idBebida;
        private string nome;
        private float valor;

        public int IdBebida { get => idBebida; set => idBebida = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
