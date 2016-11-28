using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Store;
using System.Data.Entity;

namespace CF
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();
            Product prod1 = new Product();
            prod1.ID = 1;
            prod1.Name = "Chocolate";
            prod1.Price = 10;

            prod1.Sale.ID = 1;
            prod1.Sale.SaleName = "Sale1";
            prod1.Sale.SaleSum = prod1.Price;

            rep.InsertProduct(prod1);
            prod1.Name = "Cola";
            rep.UpdateProducts(prod1);
            rep.DeleteProduct(prod1);


        }
        static void LINQ()
        {
            Product prod2 = new Product();
            prod2.ID = 1;
            prod2.Name = "Sugar";
            prod2.Price = 3;

            using (var context = new StoreDB())
            {
                var query = context.Products
                    .Where(p => p.ID == 1)
                    .Select(p => new { p.Name, p.Price, p.Sale });

                foreach (var item in query)
                {
                    Console.WriteLine("PRODUCT IS: " + item.Name + item.Price + item.Sale);
                }
            }

        }
        static void LINQ2()
        {
            Product prod2 = new Product();
            prod2.ID = 1;
            prod2.Name = "Sugar";
            prod2.Price = 3;
            prod2.Sale.SaleName = "Sale2";
            prod2.Sale.SaleSum = prod2.Price;

            using (var context = new StoreDB())
            {
                Console.WriteLine(context.Products.ToList());
            }
        }
        static void LINQ3()
        {
            Product prod2 = new Product();
            prod2.ID = 1;
            prod2.Name = "Sugar";
            prod2.Price = 3;
            prod2.Sale.SaleName = "Sale2";
            prod2.Sale.SaleSum = prod2.Price;

            using (var context = new StoreDB())
            {
                context.Products.Add(prod2);
            }
        }
    }
}
