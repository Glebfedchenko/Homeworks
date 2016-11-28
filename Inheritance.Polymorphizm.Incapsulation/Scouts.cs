using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    class Scouts
    {
        public String [] Names { get; set; }
        public int[] Number { get; set; }
        public String [] Sex { get; set; }

        public void Reward1()
        {
            Console.WriteLine("Medal of honor");
        }
        public void Reward2()
        {
            Random rnd = new Random();
            int a = rnd.Next(0,100);
            Console.WriteLine(a);
        }
        public void DisplayScouts ()
        {
            Console.WriteLine("--------------------------------Scouts---------------------------------");
            Console.WriteLine("{0,-7} {1,-10}{2}", "NUMBER", "NAME", "SEX");
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("{0,-7} {1,-10}{2}", Number[i], Names[i], Sex[i]);
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
