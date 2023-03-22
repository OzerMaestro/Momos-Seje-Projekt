using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class MenuCatalog
    {
        private List<Pizza> _pizzas;

        public MenuCatalog() { 
        _pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        
        public void UpdatePizza(int id, Pizza updatedPizza)
        {
            var pizzaToUpdate = _pizzas.Find(p => p.PizzaID== id);

            if(pizzaToUpdate != null)
            {
                pizzaToUpdate.Name = updatedPizza.Name;
                pizzaToUpdate.Bread = updatedPizza.Bread;
                pizzaToUpdate.Price = updatedPizza.Price;
            } else
            {
                Console.WriteLine("There is no pizza with that ID");
            }
        }

        public void DeletePizza(int pizzaId)
        {
            _pizzas.RemoveAll(p => p.PizzaID == pizzaId);
        }

        public Pizza SearchPizza(Pizza pizza) 
        {
            return pizza;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu\n-----");
            foreach (var pizza in _pizzas) { 
            Console.WriteLine($"Pizza ID: {pizza.PizzaID}\nName: {pizza.Name}\nBread: {pizza.Bread}\nSize: {pizza.Size}\nPrice: {pizza.Price}\n");
            }
        }
    }
}
