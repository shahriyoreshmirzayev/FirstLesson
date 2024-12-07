namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class UygaVazifa
    {
        public static void Start()
        {
            Condition1();
        }
        public static void Condition1()
        {
            var methodSyntax = Product.GetProducts().
        }

    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static List<Product> GetProducts()
        {
            List<Product> products = new()
            {
            new Product { Name = "Product1", Price = 10 },
            new Product { Name = "Product1", Price = 40 },
            new Product { Name = "Product1", Price = 150 },
            new Product { Name = "Product1", Price = 32 },
            new Product { Name = "Product1", Price = 45 },
            new Product { Name = "Product1", Price = 80 },
            new Product { Name = "Product1", Price = 75 },
            new Product { Name = "Product1", Price = 55 }
            };
            return products;
        }
    }
}
