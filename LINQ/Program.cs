using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14.Models;
namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesRepository salesRep = new SalesRepository();
            var result = from sales in salesRep.Sales
                         where sales.Discount != 0 && sales.Price >= 7 && sales.Quantity >= 2 && sales.Product.Contains("New")
                         select new
                         {
                             Name = sales.Product,
                             Summary = sales.Summary
                         };
            Console.WriteLine("SALES LIST");
            foreach (var item in result)
            {
                Console.WriteLine("ID: {0}, Sales summary: {1}", item.Name, item.Summary);
            }
            salesRep.GetSpecific();

            int pageSize = 10;
            Console.Write("What page:  ");
            int page = Convert.ToInt32(Console.ReadLine());
            result.Page(page, pageSize);

            Console.ReadKey();
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
