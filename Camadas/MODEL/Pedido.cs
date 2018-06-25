using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.MODEL
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int idPizza { get; set; }
        public int idBebida { get; set; }
        public int idCliente { get; set; }
        public float valor { get; set; }
        public int quantidade { get; set; }
        public DateTime data { get; set; }
        public string observacao { get; set; }
    }
}
