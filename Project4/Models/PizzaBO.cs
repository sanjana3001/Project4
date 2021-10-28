using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4.Models
{
    public class PizzaBO
    {
        public static List<PizzaModel> PizzaList = new List<PizzaModel>
            {
                new PizzaModel{Id=001,PizzaType="Panner", Size=50,Price=300,Quantity=50},
                new PizzaModel{Id=002,PizzaType="Veg loaded", Size=60,Price=800,Quantity=25},
                new PizzaModel{Id=003,PizzaType="Margarita", Size=70,Price=500,Quantity=40},
                new PizzaModel{Id=004,PizzaType="Veggy Farm", Size=150,Price=1000,Quantity=49},
            };
        public PizzaBO()
        {

        }
        public List<PizzaModel> getAllPizza()
        {
            return PizzaList;
        }
        public PizzaModel getPizzaById(int id)
        {
            return PizzaList.Single(x => x.Id == id);
        }
        public void order(PizzaModel p)
        {
            PizzaModel indPizza = PizzaList.Single(x => x.Id == p.Id);
            int index = PizzaList.IndexOf(indPizza);
            PizzaList[index] = p;

        }
    }
}
