using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public string Name { get; set; }
        public string Bread { get; set; }
        public string Size { get; set; }
        public int PizzaID { get; set; }
        public decimal Price { get; set; }

        public Pizza()
        {
        }

        public Pizza(string name, string bread, string size, int pizzaID, decimal price)
        {
            Name = name;
            Bread = bread;
            Size = size;
            PizzaID = pizzaID;
            Price = price;
        }


    }
}