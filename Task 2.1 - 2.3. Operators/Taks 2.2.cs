using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Double pNumber = Math.PI;
            Console.WriteLine("Please enter radius: ");
            String _Radius = Console.ReadLine();
            Console.WriteLine("Please enter length: ");
            String _Length = Console.ReadLine();
            Console.WriteLine("Please enter width: ");
            String _Width = Console.ReadLine();
            Console.WriteLine("Please enter height: ");
            String _Height = Console.ReadLine();
            Double _CircleSquare = pNumber * Math.Pow(Double.Parse(_Radius), 2);//Circle Square

            Double _SphereVolume = (4 * pNumber * Math.Pow(Double.Parse(_Radius), 3)) / 3;//Sphere Volume

            Double _SquareRectangle = Convert.ToDouble(_Length) * Convert.ToDouble(_Width); //Rectangle Square

            Double _RectParallel = Convert.ToDouble(_Length) * Convert.ToDouble(_Width) * Convert.ToDouble(_Height);//Rectangular Parallelepiped volume

            Console.WriteLine("Circle Square is : {0}, Sphere Volume is: {1}, Rectangle Square is: {2}, Rectangular Parallelepiped Volume is: {3}", _CircleSquare, _SphereVolume, _SquareRectangle, _RectParallel);
            Console.ReadKey();
        }
    }
}
