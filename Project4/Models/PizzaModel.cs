using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is PizzaModel))
            {
                return false;
            }
            return (this.Id == ((PizzaModel)obj).Id)
                && (this.PizzaType == ((PizzaModel)obj).PizzaType) && (this.Quantity == ((PizzaModel)obj).Quantity) && (this.Price == ((PizzaModel)obj).Price)
                && (this.Size == ((PizzaModel)obj).Size);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ PizzaType.GetHashCode() ^ Quantity.GetHashCode() ^ Price.GetHashCode() ^ Size.GetHashCode();
        }
    }
}
