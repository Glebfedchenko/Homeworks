using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local variables
            int _Scout = 0;
            #endregion
            #region Initializing objects
            Scouts Scouts = new Scouts();
            Scouts.Names = new String[] { "Oleg", "Petya", "Vasya", "Stepan", "Kesha", "Nastya", "Anzela", "Vera", "Zhanna", "Vasilisa" };
            Scouts.Number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Scouts.Sex = new String[] { "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female", "Female" };
            Boys Boy = new Boys();
            Girls Girl = new Girls();
            #endregion
            
            Scouts.DisplayScouts();

            Girl.Reward2();
            Console.WriteLine("Choose scout number to add sport");
            _Scout = getNumber();
            switch (_Scout)
            {
                case 1: Boy.BoySport(); break;
                case 2: Boy.BoySport(); break;
                case 3: Boy.BoySport(); break;
                case 4: Boy.BoySport(); break;
                case 5: Boy.BoySport(); break;
                case 6: Girl.GirlSport(); break;
                case 7: Girl.GirlSport(); break;
                case 8: Girl.GirlSport(); break;
                case 9: Girl.GirlSport(); break;
                case 10: Girl.GirlSport(); break;
                default: break;
            }
            Console.ReadKey();
        }

        static int getNumber()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Error in input");
            }
            return 0;
        }
    }
}
