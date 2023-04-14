using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Class
{
    internal class FixedPriceProduct : Product
    {
        public override string ToString()
        {
           return $"{base.ToString()}" + 
                  $"\n\tProducut price:............{$"{ValueToPay():C2}", 20}" +
                  $"\n\tProduct TAX:...............{$"{Tax:P2}",20}" +
                  $"\n\tValue:.....................{$"{ValueToPay():C2}", 20}";
        }
        public override decimal ValueToPay()
        {
            float tax = Tax * (float)Price;
            return Price += (decimal)tax ; 
        }
    }
}
