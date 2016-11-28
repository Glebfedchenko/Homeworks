using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractBot;
using USAbot;
using Spainbot;
using UAbot;
namespace Task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creating instances
            USAbot.USA american = new USA()
            {
                Name = "Roger"
            };
            UAbot.UA ukrainian = new UA()
            {
                Name = "Stepan"
            };
            Spainbot.ES spaniard = new ES()
            {
                Name = "Hose"
            };
            #endregion
            #region MainDialogue

            Console.WriteLine("Please enter your language: ");
            Console.WriteLine("1. United States" + Environment.NewLine + "2. Ukraine" + Environment.NewLine + "3. Spanish" + Environment.NewLine);
            String a = Console.ReadLine();

            switch (a)
            {
                case "1": american.Use(); break;
                case "2": ukrainian.Use(); break;
                case "3": spaniard.Use(); break;
                default:
                    break;
            }
            #endregion
            Console.ReadKey();
        }
    }
    #region
    enum Nationality { Ukrainian = '2', Spaniard = '3', American = '1' }
    #endregion
}
