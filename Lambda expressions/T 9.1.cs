using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double num;

            Console.WriteLine("Insert string or number: ");

            str = Console.ReadLine();

            if (double.TryParse(str, out num))
            {
                Console.WriteLine("You entered number ");
                Operation<double>.Menu();
                num = Math.Pow(num, 2);
                Operation<double>.op(Console.ReadLine(), num);
            }
            else
            {
                Console.WriteLine("You entered string ");
                Operation<string>.Menu();
                Operation<string>.op(Console.ReadLine(), str);
            }

            Console.ReadLine();
        }
    }

    class Operation<T>
    {
        static public Func<string, T, string> op = (i, str) =>
        {
            int list = 0;

            int.TryParse(i, out list);

            switch (list)
            {
                case 1:
                    WriteText(str.ToString());
                    return "Wrote In file";
                case 2:
                    Console.WriteLine(str);
                    return str.ToString();
                default:
                    return "ERROR: Wrong operation!";

            }
        };

        static public void Menu()
        {
            Console.WriteLine("1. Save to the file");
            Console.WriteLine("2. Print to the console");
        }

        static private void WriteText(string str)
        {
            File.WriteAllText("Lambda.txt", str);
        }
    }
}

