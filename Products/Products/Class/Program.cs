using Products.Class;
using System.Text;

Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");



Product product1 = new FixedPriceProduct()
{

    Description = "Vino gato negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F,


};
Product product2 = new FixedPriceProduct()
{
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};


Product product3 = new VariablePriceProduct()
{
    Description = "Queso Holandes",
    Id = 3030,
    Measurement = "Kilo",
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};
Product product4 = new VariablePriceProduct()
{
    Description = "Cabano",
    Id = 4040,
    Measurement = "Kilo",
    Price = 18000M,
    Quantity = 0.389F,
    Tax = 0.19F
};



ICollection<Product> products = new List<Product>()
{
    product1, product2, product3, product4
};
decimal payRoll = 0;
string ProductsListName= string.Empty;
foreach (Product product in products)
{
    Console.WriteLine(product);
    payRoll += product.ValueToPay();
    ProductsListName += product.Description+',';    
}
Console.WriteLine("\n\t===================================\n\t");

Product product5 = new ComposedProduct()
{
    Description = "Ancheta #1",
    Discount = 0.12F,
    Id = 5050,
    Products = $"{ProductsListName}",
    Price = payRoll,
};
Console.WriteLine(product5);

Invoice invoice = new Invoice();
invoice.AddProduct(product1);
invoice.AddProduct(product3);
invoice.AddProduct(product5);
Console.WriteLine(invoice);



//Console.WriteLine(product1);
//Console.WriteLine(product2);
//Console.WriteLine(product3);
//Console.WriteLine(product4);
//Console.WriteLine(product5);


