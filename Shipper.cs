using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    internal class Shipper
    {

        private int numBaseballGloves;
        private int numBicycles;
        private int numCrackers;
        private int numLawnMowers;

        List<IShippable> shippables = new List<IShippable>();

        public void Add(IShippable item)
        {
            switch (item)
            {
                case BaseballGlove:
                    numBaseballGloves++;
                    break;
                case Bicycle:
                    numBicycles++;
                    break;
                case Crackers:
                    numCrackers++;
                    break;
                case LawnMower:
                    numLawnMowers++;
                    break;
            }

            shippables.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("Shipment Manifest:");
            if (numBaseballGloves > 0)
            {
                if (numBaseballGloves == 1)
                {
                    Console.WriteLine(numBaseballGloves + " Baseball Glove");
                }
                else
                {
                    Console.WriteLine(numBaseballGloves + " Baseball Gloves");
                }
            }
            if (numBicycles > 0)
            {
                if(numBicycles == 1)
                {
                    Console.WriteLine(numBicycles + " Bicycle");
                }
                else
                {
                    Console.WriteLine(numBicycles + " Bicycles");
                }
            }
            if (numCrackers > 0)
            {
                Console.WriteLine(numCrackers + " Crackers");
            }
            if(numLawnMowers > 0)
            {
                if(numLawnMowers == 1)
                {
                    Console.WriteLine(numLawnMowers + " Lawn Mower");
                }
                else
                {
                    Console.WriteLine(numLawnMowers + " Lawn Mowers");
                }
            }
        }

        public decimal Shippingcost()
        {
            decimal totalship = 0;

            foreach(IShippable item in shippables)
            {
                totalship += item.ShipCost;
            }
            return totalship;
        }
    }
}
