using System;

namespace methots
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Productname = "Elma";
            product1.Price = 15;
            product1.Explanation = "amasya elması";

            Product product2 = new Product();
            product2.Productname = "Karpuz";
            product2.Price = 85;
            product2.Explanation = "diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Productname);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------------");

            }
            Console.WriteLine("----------METOTLAR----------");


            Basketmanager basketmanager = new Basketmanager();
            basketmanager.Ekle(product1);
            basketmanager.Ekle(product2);

        }
    }
}
