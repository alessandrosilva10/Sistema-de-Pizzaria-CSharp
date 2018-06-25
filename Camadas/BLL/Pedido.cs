
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace Sistema_de_Pizzaria.Camadas.BLL
{
    public class Pedido
    {
        Camadas.DAL.Pedido dalPedido = new DAL.Pedido();

        public List<MODEL.Pedido> Select()
        {
            return dalPedido.Select();
        }

        public void Insert(MODEL.Pedido pedido)
        {
            DAL.Pedido dalPedido = new DAL.Pedido();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();


            List<MODEL.Pedido> lstPedido = new List<MODEL.Pedido>();
            lstPedido = bllPedido.Select();

            pedido.valor = Convert.ToSingle(pedido.valor + (pedido.valor * 0.10));
            bllPedido.Update(pedido);
            dalPedido.Insert(pedido);

            MessageBox.Show("Devido ao Lula e sua turma, será cobrado um valor a mais de 10% como forma de imposto :)", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                
        }

        public List<MODEL.Pedido> SelectId(int idPedido)
        {
            DAL.Pedido dalPedido = new DAL.Pedido();
            return dalPedido.SelectId(idPedido);
        }

        public void Update(MODEL.Pedido pedido)
        {
            dalPedido.Update(pedido);
        }

        public void Delete(int idPedido)
        {
            dalPedido.Delete(idPedido);          
        }
    }
}