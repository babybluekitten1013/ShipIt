using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    public class Bicycle : IShippable
    {
        private decimal shippingcost;
        private string name;

        public Bicycle()
        {
            shippingcost = 20.50m;
            name = "Bicycle";
        }

        public Bicycle(decimal shippingcost, string name)
        {
            this.shippingcost = shippingcost;
            this.name = name;
        }

        public decimal ShipCost { get { return shippingcost;} } 
        public string Product { get { return name;} }
    }
}
