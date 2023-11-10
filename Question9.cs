using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessentOne {
    internal class Pizza {
        
        private string _size;
        private int _cheeseToppings;
        private int _olivesToppings;
        private int _redCapsicumToppings;

        
        public Pizza(string size, int cheeseToppings, int olivesToppings, int redCapsicumToppings) {
            _size = size;
            _cheeseToppings = cheeseToppings;
            _olivesToppings = olivesToppings;
            _redCapsicumToppings = redCapsicumToppings;
        }

        
        public string Size {
            get { return _size; }
            set { _size = value; }
        }


        public int CheeseToppings {
            get { return _cheeseToppings; }
            set { _cheeseToppings = value; } 
        }
  
        public int OlivesToppings {
            get { return _olivesToppings; }
            set { _olivesToppings = value;}
        }

        public int RedCapsicumToppings {
            get { return _redCapsicumToppings;}
            set { _redCapsicumToppings=value;}
        }


        public double CalcCost() {
            double costPerTopping = 0.0;

            switch (_size.ToLower()) {
                case ("small"):
                    costPerTopping = 100.0;
                    break;
                case ("medium"):
                    costPerTopping = 200.0;
                    break;
                case ("large"):
                    costPerTopping = 300.0;
                    break;
               
                default:
                    break;
            }

            int toppingsCount = _cheeseToppings + _olivesToppings + _redCapsicumToppings;
            return toppingsCount * costPerTopping;
        }

        // Public method named getDescription() that returns a string containing pizza size and toppings quantity
        public string GetDescription() {
            return $"Pizza Size: {Size}, Cheese Toppings: {CheeseToppings}, Olives Toppings: {OlivesToppings}, Red Capsicum Toppings: {RedCapsicumToppings}";
        }
    }
    internal class Question9 {
        public static void Run() {
            Console.WriteLine("Question9");
            Console.Write("Enter number of pizza: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Pizza> pizzaList = new List<Pizza>();
            for(int pizzaIndex = 0; pizzaIndex < n; pizzaIndex++) {
                string size;
                int cheeseToppings;
                int olivesToppings;
                int redCapsicumToppings;
                Console.WriteLine($"Pizza {pizzaIndex + 1} Details:");
                Console.Write("Enter Size (small, medium, large) : ");
                size = Console.ReadLine();
                Console.Write("Enter Cheese Toppings: ");
                cheeseToppings = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Olives Toppings: ");
                olivesToppings = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Red Capsicum Toppings: ");
                redCapsicumToppings = Convert.ToInt32(Console.ReadLine());
                Pizza pizza = new Pizza(size,cheeseToppings,olivesToppings,redCapsicumToppings);
                pizzaList.Add(pizza);
            }
            for(int pizzaIndex = 0;pizzaIndex< pizzaList.Count; pizzaIndex++) {
                Console.WriteLine(pizzaList[pizzaIndex].GetDescription());
            }
        }
    }
}
