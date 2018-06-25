using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema_de_Pizzaria.Camadas.BLL
{
    public class Pizza
    {
        DAL.Pizza dalPizza = new DAL.Pizza();

        public List<MODEL.Pizza> Select()
        {
            return dalPizza.Select();
        }

        public List<MODEL.Pizza> Select(int idPizza)
        {
            return dalPizza.Select(idPizza);
        }

        public List<MODEL.Pizza> Select(string nome)
        {
            return dalPizza.Select(nome);
        }

        public void Insert(MODEL.Pizza pizza)
        {
            dalPizza.Insert(pizza);   
        }

        public void Update(MODEL.Pizza pizza)
        {
            dalPizza.Update(pizza);
        }

        public void Delete(int idPizza)
        {
            dalPizza.Delete(idPizza);
        }

    }

}

