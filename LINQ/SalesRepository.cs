using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14.Models
{
    class SalesRepository
    {
        public List<Sales> Sales { get; set; }

        public SalesRepository()
        {
            Sales = new List<Sales>()
            {
                new Sales() { Id = 1, Product="New Lexus", Price = 30 , Quantity =3, Discount = 1, Summary = 87},
                new Sales() { Id = 2, Product="Hyundai", Price = 5, Quantity =1, Discount = 0, Summary = 5},
                new Sales() { Id = 3, Product="New Honda", Price = 15, Quantity =12, Discount = 1, Summary = 180},
                new Sales() { Id = 5, Product="New BMW", Price = 7, Quantity =4, Discount = 1, Summary = 24},
                new Sales() { Id = 6, Product="New Audi", Price = 7, Quantity =4, Discount = 1, Summary = 24},
                new Sales() { Id = 7, Product="New Akura", Price = 7, Quantity =4, Discount = 1, Summary = 24},
                new Sales() { Id = 8, Product="Toyota", Price = 7, Quantity =4, Discount = 1, Summary = 24},

            };         
        }

        public void GetSpecific()
        {
            SalesRepository sales = new SalesRepository();
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();

            var result = from sale in sales.Sales
                         where sale.Product.Contains(keyword)
                         select sale.Product;
                            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static class Paging
        {
            public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
            {
                return source.Skip((page - 1) * pageSize).Take(pageSize);
            }

        }
    }
}
