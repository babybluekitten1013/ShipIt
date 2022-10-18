using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    public class BaseballGlove : IShippable
    {        
        
        private decimal shippingcost;
        private string name;

        public BaseballGlove()
        {
            shippingcost = 3.23m;
            name = "Baseball Glove";
        }

        public BaseballGlove(decimal shippingcost, string name)
        {
            this.shippingcost = shippingcost;
            this.name = name;
        }

        public decimal ShipCost { get { return shippingcost;} }  
        public string Product { get { return name;} } 
    }
}
