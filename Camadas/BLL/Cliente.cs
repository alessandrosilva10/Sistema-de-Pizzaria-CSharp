using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.BLL
{

    public class Cliente
    {
        Camadas.DAL.Cliente dalCliente = new DAL.Cliente();

        public List<MODEL.Cliente> Select()
        {
            return dalCliente.Select();
        }

        public List<MODEL.Cliente> Select(int idPizza)
        {
            return dalCliente.Select(idPizza);
        }

        public List<MODEL.Cliente> Select(string nome)
        {
            return dalCliente.Select(nome);
        }

        public void Insert(MODEL.Cliente cliente)
        {
            dalCliente.Insert(cliente);
        }

        public void Update(MODEL.Cliente cliente)
        {
            dalCliente.Update(cliente);
        }

        public void Delete(int idCliente)
        {
            dalCliente.Delete(idCliente);
        }
    }
}
