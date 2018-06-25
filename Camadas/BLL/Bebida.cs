using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pizzaria.Camadas.BLL
{
    public class Bebida
    {
        DAL.Bebida dalBebida = new DAL.Bebida();

             public List<MODEL.Bebida> Select()
             {
             return dalBebida.Select();
             }

            public void Insert(MODEL.Bebida bebida)
            {
                dalBebida.Insert(bebida);
            }
       
           public void Update(MODEL.Bebida bebida)
           {
               dalBebida.Update(bebida);
           }

           public void Delete(int idBebida)
           {
               dalBebida.Delete(idBebida);
           }
    }
}
