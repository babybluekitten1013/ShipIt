using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipIt
{
    public class LawnMower : IShippable
    {

        private decimal shippingcost;
        private string name;
        public LawnMower()
        {
            shippingcost = 24.00m;
            name = "Lawn Mower";
        }

        public LawnMower(decimal shippingcost, string name)
        {
            this.shippingcost = shippingcost;
            this.name = name;
        }

        public decimal ShipCost { get {  return shippingcost;} }  
        public string Product { get { return name;} }  
    }
}
