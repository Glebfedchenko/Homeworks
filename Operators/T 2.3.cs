using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 _X = 5;
            Int32 _Y = 12;
            Int32 _Z = 2;
            Int32 _Res = (_X++ - --_Y + --_X << _Z++) * (_X + _Y + _Z);
            Console.WriteLine("5(postfix increment to 6)-11(prefix decrement)+5(prefix decrement from 6 to 5)<<2 = -4");
            Console.WriteLine("5+11+3 = 19");
            Console.WriteLine(_Res);
            Console.ReadKey();
        }
    }
}
