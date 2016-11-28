using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class ProductOp
    {
        static public bool check = false;
        static private int result;
        static private int amount;

        #region Arrays : | Names | IDs | Prices |
        private static string[] Names = new string[] { "Apple", "Milk", "Bread", "Cola", "Chocolate" };
        private static int[] Ids = new int[] { 1, 2, 3, 4, 5 };
        private static double[] Prices = new double[] { 1.45, 0.99, 1.4, 1.15, 25.25 };
        #endregion

        #region Collections: | ProductList | IdsChecked | Amounts |
        static IDictionary<string, Product> list = new Dictionary<string, Product>();

        static List<int> IdsChecked = new List<int>();

        static List<int> Amounts = new List<int>();
        #endregion

        #region MkEx Method for making objects 
        static public void MkEx()
        {
            foreach (string name in Names)
            {
                list[name] = new Product(Ids[Array.IndexOf(Names, name)], Names[Array.IndexOf(Names, name)], Prices[Array.IndexOf(Names, name)]);
            }
        }
        #endregion

        #region ProductList Method for showing a product list
        static public void ProductList()
        {
            Console.WriteLine(String.Format("{0} {1} {2}", new String('-', 8), "Product List", new String('-', 8)));
            Console.WriteLine("{0, -4} {1, -15} {2}", "ID", "NAME", "PRICE");
            Console.WriteLine();

            foreach (string name in Names)
            {
                Console.WriteLine("{0, -4} {1, -14}: $ {2:0.00}", list[name].Id, list[name].Name, list[name].Price);//To output obj value list[name].Id/Name/Price
            }

            Console.WriteLine();
            Console.WriteLine("{0, -4} {1, -15}", Names.Length + 1, "EXIT");
            Console.WriteLine(new String('-', 30));
        }
        #endregion
        #region CheckId Method for checking inserted id
        static public void CheckId()
        {
            while (!check)
            {
                Console.WriteLine("Insert ID");
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result > 0 && result <= Ids.Length + 1)
                    {
                        ProductOp.check = true;
                    }
                }
            }
        }
        #endregion

        #region CheckAmount Method 
        static public void CheckAmount()
        {
            Console.WriteLine("Insert amount");
            while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0 || amount % 1 != 0)
            {
                Console.WriteLine("Insert amount");
            }
            check = false;
        }
        #endregion

        #region GetId Method
        static public int GetId()
        {
            return result;
        }
        #endregion

        #region IdsLength Method
        static public int IdsLength()
        {
            return Ids.Length;
        }
        #endregion

        #region AddToList Method for adding elements to lists:  | IdsChecked | Amount | 
        static public void AddToList(int iArg)
        {
            IdsChecked.Add(result);
            Amounts.Add(amount);
        }
        #endregion

        #region Total count total 
        static public double Total(int iArg)
        {
            double total = 0;
            for (int j = 0; j < iArg; j++)
            {
                total += ((double)Amounts[j] * Prices[IdsChecked[j] - 1]);
            }
            return total;
        }
        #endregion

        #region OutPutCheck Method for outputing in Console order
        static public void OutPutCheck(int iArg)
        {
            double discount = 0;
            Discount(ref discount);
            Console.WriteLine(String.Format("{0} {1} {2}", new String('-', 8), "Your order", new String('-', 8)));
            for (int i = 0; i < iArg; i++)
            {
                Console.WriteLine("{0, -15}: * {1} $ {2: 0.00}", Names[IdsChecked[i] - 1], Amounts[i], Prices[IdsChecked[i] - 1] * Amounts[i]);
            }
            Console.WriteLine();
            if (discount == 0)
            {
                Console.WriteLine("TOTAL: $ {0:0.00} ", Total(iArg));
            }
            else
            {
                Console.WriteLine("DISCOUNT: - $ {0:0.00} ", Total(iArg) * discount / 100);
                Console.WriteLine("TOTAL: $ {0:0.00} ", Total(iArg) - Total(iArg) * discount / 100);
            }
        }
        #endregion

        #region Discount Method 
        static public void Discount(ref double discount)
        {
            Console.WriteLine("Do You have a discount ? ( y / n )");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    Console.WriteLine("Enter discount discount value (%)");
                    discount = int.Parse(Console.ReadLine());
                    if (discount < 0 || discount > 100)
                    {
                        Discount(ref discount);
                    }
                    break;
                case "n":
                    break;
                default:
                    Discount(ref discount);
                    break;
            }
        }
        #endregion
    }
}

