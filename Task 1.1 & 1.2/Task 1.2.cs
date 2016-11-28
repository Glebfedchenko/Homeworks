using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello world!";
            for (int i = 0; i < myString.Length; i++)
            {
                int toDec = Convert.ToInt32(myString[i]);
                string toHex = String.Format("{0:X}", toDec);
                Console.WriteLine("Char {0}: Dec {1}, Hex {2}", myString[i], toDec, toHex);
            }
            Console.ReadKey();
        }
    }
}
