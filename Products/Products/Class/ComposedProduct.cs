namespace Products.Class

{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public string Products { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tProducts :.................{$"{Products}",20}" +
                   $"\n\tDiscount :.................{$"{Discount:P2}",20}" +
                   $"\n\tValue    :.................{$"{ValueToPay():C2}",20}";
        }

        public override decimal ValueToPay()
        {
            float discount = Discount * (float)Price;
            float tax = Tax * (float)Price;            
            return Price += (decimal)tax - (decimal)discount;   
        }
    }
}
