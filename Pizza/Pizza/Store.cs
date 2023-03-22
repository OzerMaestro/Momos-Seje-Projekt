using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Store
    {
        private MenuCatalog catalog = new MenuCatalog();
        public void start()
        {
            var pizza1 = new Pizza() { PizzaID = 1, Name = "mems", Bread = "Kids", Size = "Standard", Price = 60 };
            var pizza2 = new Pizza() { PizzaID = 2, Name = "mems", Bread = "Family size", Size = "Standard", Price = 75 };
            var pizza3 = new Pizza() { PizzaID = 3, Name = "mems", Bread = "Normal", Size = "Standard", Price = 90 };

            catalog.AddPizza(pizza1);
            catalog.AddPizza(pizza2);
            catalog.AddPizza(pizza3);

            List<string> menuItems = new List<string>
            {
                "Add new pizza to the menu",
                "Delete pizza from the menu",
                "Update pizza on the menu",
                "Search for a pizza",
                "Display pizza menu\n"
            };

            MenuChoice(menuItems);
        }

        public void MenuChoice(List<string> menuItems)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Please choose an option:");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }
                Console.WriteLine("0. Exit\n");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please use a integer between 0 and 5");
                    continue;
                }

                if (choice == 0)
                {
                    exit = true;
                }

                int id;
                string name;
                string bread;
                string size;
                decimal price;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter pizza id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter pizza name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter bread:");
                        bread = Console.ReadLine();
                        Console.WriteLine("Enter pizza size");
                        size = Console.ReadLine();
                        Console.WriteLine("Enter pizza price");
                        price = Convert.ToDecimal(Console.ReadLine());
                        var newPizza = new Pizza() { PizzaID = id, Name = name, Bread = bread, Price = price, Size = size };
                        catalog.AddPizza(newPizza);
                        break;

                    case 2:
                        Console.WriteLine("Choose the id on the pizza you want to delete:");
                        id = Convert.ToInt32(Console.ReadLine());
                        catalog.DeletePizza(id);
                        Console.WriteLine($"Pizza with {id} is now delete\n");
                        break;

                    case 3:
                        Console.WriteLine("Choose id on the pizza you want to update");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choose new name for the pizza");
                        name = Console.ReadLine();
                        Console.WriteLine("Choose new bread for the pizza");
                        bread = Console.ReadLine();
                        Console.WriteLine("Choose new price for the pizza");
                        price = Convert.ToDecimal(Console.ReadLine());
                        var updatedPizza = new Pizza() { Name = name, Bread = bread, Price = price };
                        catalog.UpdatePizza(id, updatedPizza);
                        Console.WriteLine($"Pizza with {id} is now updated");
                        break;
                    case 4:

                        break;
                    case 5:
                        catalog.PrintMenu();
                        break;
                }
            }
        }
    }
}
