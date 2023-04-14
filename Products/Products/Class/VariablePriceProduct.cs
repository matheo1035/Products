using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Class
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public  float Quantity { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tProduct measurement type:..{$"{Measurement}", 20}" +
                   $"\n\tProductQuantity:...........{$"{Quantity:N2}", 20}" +
                   $"\n\tProducut price:............{$"{ValueToPay():C2}",20}" +
                   $"\n\tProduct TAX:...............{$"{Tax:P2}",20}" +
                   $"\n\tValue:.....................{$"{ValueToPay():C2}", 20}";
        }
        public override decimal ValueToPay()
        {
            float tax = Tax * (float)Price;
            return Price += (decimal)tax;
        }
    }

}
