using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            Console.WriteLine("Type byte: " + "default value = " + default(byte) + ", min = " + byte.MinValue + ", max = " + byte.MaxValue);
            //sbyte
            Console.WriteLine("Type sbyte: " + "default value = " + default(sbyte) + ", min = " + sbyte.MinValue + ", max = " + sbyte.MaxValue);
            ////short
            Console.WriteLine("Type short: " + "default value = " + default(short) + ", min = " + short.MinValue + ", max = " + short.MaxValue);
            ////ushort
            Console.WriteLine("Type ushort: " + "default value = " + default(ushort) + ", min = " + ushort.MinValue + ", max = " + ushort.MaxValue);
            ////int
            Console.WriteLine("Type int: " + "default value = " + default(int) + ", min = " + int.MinValue + ", max = " + int.MaxValue);
            ////uint
            Console.WriteLine("Type uint: " + "default value = " + default(uint) + ", min = " + uint.MinValue + ", max = " + uint.MaxValue);
            ////long
            Console.WriteLine("Type long: " + "default value = " + default(long) + ", min = " + long.MinValue + ", max = " + long.MaxValue);
            ////ulong
            Console.WriteLine("Type ulong: " + "default value = " + default(ulong) + ", min = " + ulong.MinValue + ", max = " + ulong.MaxValue);
            ////float
            Console.WriteLine("Type float: " + "default value = " + default(float) + ", min = " + float.MinValue + ", max = " + float.MaxValue);
            ////double
            Console.WriteLine("Type double: " + "default value = " + default(double) + ", min = " + double.MinValue + ", max = " + double.MaxValue);
            ////decimal
            Console.WriteLine("Type decimal: " + "default value = " + default(decimal) + ", min = " + decimal.MinValue + ", max = " + decimal.MaxValue);
            ////bool
            Console.WriteLine("Type boolean: " + "default value = " + default(bool));
            ////char
            Console.WriteLine("Type char: " + "default value = " + default(char));

            Console.ReadKey();
        }
    }
}
