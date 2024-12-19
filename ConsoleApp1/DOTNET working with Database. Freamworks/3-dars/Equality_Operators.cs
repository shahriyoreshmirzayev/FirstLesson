using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Equality_Operators
    {
        public static void Start()
        {
            //Equals1();
            //Equals2();
            Equal();
        }
        public static void Equals1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 5, 13, 14, 5, 16, 17, 18, 5 };
            //Method Syntax
            var ResultMS = numbers.Where(num => num.Equals(5)).Select(num => num).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var result in ResultMS)
            {
                Console.WriteLine(result);
            }

            //Using Query Syntax
            var ResultQS = (from  result in numbers
                            select result).
                            Where(num => num.Equals(5)).
                            Select(num => num).
                            ToList();
            Console.WriteLine("Query Syntax");

            foreach(var result in ResultQS)
            {
                Console.Write(result + " ");
            }
            Console.Read();
        }
        public static void Equals2()
        {
            Product product = Product.GetProducts()[0];
            Product stul = new Product()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName
            };
            Console.WriteLine($"Product: {product.ProductName}, ID: {product.ProductID}");
            Console.WriteLine($"Stull: {stul.ProductName}, ID {stul.ProductID}");
            Console.WriteLine("Stull Equals: " + stul.Equals(product));

            //Using Query Syntax
            var ResultQS = (from pro in Product.GetProducts()
                            where pro.Equals( stul )
                            select pro).ToList();
            foreach (var result in ResultQS)
            {
                Console.WriteLine(result);
            }
            Console.Read();
        }
        public static void ReferenceEquals()
        {
            Product product = Product.GetProducts()[0];
            Product stul = new Product()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName
            };
            Console.WriteLine($"Product: {product.ProductName}, ID: {product.ProductID}");
            Console.WriteLine($"Stull: {stul.ProductName}, ID {stul.ProductID}");
            Console.WriteLine("Stull Equals: " + object.ReferenceEquals(stul, product));


            product = Product.GetProducts()[0];
            var referenceEqualsProducts = (from pro in Product.GetProducts()
                                           where ReferenceEquals(pro.ProductName, product.ProductName)
                                           select pro).ToList();
            referenceEqualsProducts.ForEach(p => Console.WriteLine(p.ProductName));
        }
        public static void Equal()
        {
            Product product = Product.GetProducts()[0];
            Product stul = new Product()
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName
            };
            Console.WriteLine(stul == product);

            var referencesEquals = (from pro in Product.GetProducts()
                                    where pro.ProductName == product.ProductName
                                    select pro).ToList();
            referencesEquals.ForEach(p => Console.WriteLine(product.ProductName));

            Console.Read();
        }
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { ProductID = 1, ProductName = "Stul" },
                new Product { ProductID = 2, ProductName = "Divan" },
                new Product { ProductID = 3, ProductName = "Kompyuter" },
                new Product { ProductID = 4, ProductName = "TV" },
                new Product { ProductID = 5, ProductName = "Muzlatkich" }
            };
        }
    }
}
