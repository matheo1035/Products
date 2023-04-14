using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Class
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public decimal Value { get; set; }
        public override string ToString()
        {
            return $"\n\tProduct description:.......{$"{Description}", 20}" +
                   $"\n\tProduct ID:................{$"{Id}", 20}";
        }
        public abstract decimal ValueToPay();
    }
}
