using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt 
{
    public class Program 
    {               
        static Shipper shipper = new Shipper();
        
        public static void Main()
        {
            bool IsRunning = true;

            while (IsRunning)
            {
                IsRunning = MainMenu();
            }

        }

        public static bool MainMenu()
        {
            Console.WriteLine("1. Add a Baseball Glove to the shipment");
            Console.WriteLine("2. Add a Bicycle to the shipment");
            Console.WriteLine("3. Add Crackers to the shipment");
            Console.WriteLine("4. Add a Lawn Mower to the shipment");
            Console.WriteLine("5. List Shipment items");
            Console.WriteLine("6. Compute Shipping Costs");            
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    shipper.Add(new BaseballGlove());
                    Console.WriteLine("A Baseball Glove has been added");
                    Console.WriteLine();
                    return true;
                case "2":
                    Console.WriteLine();
                    shipper.Add(new Bicycle());
                    Console.WriteLine("A Bicycle has been added");
                    Console.WriteLine();
                    return true;
                case "3":
                    Console.WriteLine();
                    shipper.Add(new Crackers());
                    Console.WriteLine("Crackers have been added");
                    Console.WriteLine();
                    return true;
                case "4":
                    Console.WriteLine();
                    shipper.Add(new LawnMower());
                    Console.WriteLine("A Lawn Mower has been added");
                    Console.WriteLine();
                    return true;
                case "5":
                    Console.WriteLine();
                    shipper.Display();
                    Console.WriteLine();
                    return true;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine("Total shipping costs for this order are " + string.Format("{0:c}", shipper.Shippingcost()));
                        return false;
            }
            return true;
        }
    } 
}



