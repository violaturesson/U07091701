using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upgA
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int max = 0;
            double summa = 0;

            //List w/ all products
            ArrayList products = new ArrayList();
            products.Add(new Product() {Name="Röd Groda", Price=30});
            products.Add(new Product() { Name = "Blå Groda", Price = 20 });
            products.Add(new Product() { Name = "Grön Groda", Price = 50 });
            products.Add(new Product() { Name = "Lila Groda", Price = 40 });
            products.Add(new Product() { Name = "Svart Groda", Price = 35 });


            //Number of products
            Console.WriteLine("Det finns "+products.Count +" produkter i listan.");


            //Space
            Console.WriteLine();


            //Write out products
            for (int i = 0; i < (products.Count-1); i++)
            {
                Product p = (Product)products[i];
                Console.Write(p.Name+ "|");
            }
            Product s = (Product)products[products.Count - 1];
            Console.Write(s.Name);

            //Find highest price
            foreach (Product p  in products)
            {
                if (p.Price > max)
                {
                    max = p.Price;
                }
            }

            //Highest price
            Console.WriteLine("Den dyraste produkten kostar "+ max + "kr");

            //Find average
            foreach (Product p in products)
            {
                summa += (double)p.Price;
            }
            double medel = summa / products.Count;

            //Average price
            Console.WriteLine("Snittpriset på alla produkter är "+ medel + "kr");

            //List all products
            foreach (Product p in products)
            {
                Console.WriteLine(p.Name+" ("+p.Price+"kr)");
            }
        }
    }
}
