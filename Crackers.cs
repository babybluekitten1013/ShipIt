using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    public class Crackers : IShippable
    {
        private decimal shippingcost;
        private string name;
        
        public Crackers()
        {
            shippingcost = .57m;
            name = "Crackers";
        }

        public Crackers (decimal shippingcost, string name)
        {
            this.shippingcost = shippingcost;
            this.name = name;
        }

        public decimal ShipCost { get { return shippingcost; } }
        public string Product { get { return name; } }
    }
}
