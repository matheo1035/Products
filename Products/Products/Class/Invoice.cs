namespace Products.Class
{
    public class Invoice : IPay
    {
        private object _Products;
       
        public object AddProduct(object Products)
        {
            ICollection<Product> products = new List<Product>();
            {
                _Products = Products;               
            }            
            return _Products;
        }
        public override string Invoice()
        {
            return (string)_Products;
        }
        public override string ToString()
        {
            return $"Productos:.......{_Products:C2}" +
                   $"\n\tTOTAL:.......{ValueToPay():C2}";            

        }
        public decimal ValueToPay()
        {
            ICollection<Product> products = new List<Product>();
            decimal payRoll = 0;            
            foreach (Product product in products)
            { 
                payRoll += product.Value;
            }
            return payRoll; 
        }
    }
}
