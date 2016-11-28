using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double _FirstNumb = 0;
            Double _SecondNumb = 0;


            while (true)
            {
                Console.WriteLine("Please enter first number and press enter");
                _FirstNumb = GetNumber();
                Console.WriteLine("Please enter operation: + , - , / , * , % , ^ , and press enter");
                String A = Operation();
                Console.WriteLine("Please enter second number and press enter");
                _SecondNumb = GetNumber();
                if (A == "+")
                {
                    Console.WriteLine("Result is: " + Addition(_FirstNumb, _SecondNumb));
                }
                else if (A == "-")
                {
                    Console.WriteLine("Result is: " + Substraction(_FirstNumb, _SecondNumb));
                }
                else if (A == "*")
                {
                    Console.WriteLine("Result is: " + Multiplication(_FirstNumb, _SecondNumb));
                }
                else if (A == "/")
                {
                    Console.WriteLine("Result is: " + Division(_FirstNumb, _SecondNumb));
                }
                else if (A == "%")
                {
                    Console.WriteLine("Result is: " + Modulus(_FirstNumb, _SecondNumb));
                }
                else if (A == "^")
                {
                    Console.WriteLine("Result is: " + Power(_FirstNumb, _SecondNumb));
                }
                else
                {
                    Console.WriteLine("Input Error!");
                }
                Console.ReadKey();
            }
        }
        //Get Number
        static Double GetNumber()
        {
            Double x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        //Get Operation
        static String Operation()
        {
            String A = Convert.ToString(Console.ReadLine());
            return A;
        }
        //Check
        static Boolean CheckOperation(String Sign, out Double Result)
        {
            Result = 0;
            return Double.TryParse(Sign, out Result);
        }
        //operations
        static Double Addition(Double _Value1, Double _Value2)
        {
            Double result = _Value1 + _Value2;
            return result;
        }
        static Double Substraction(Double _Value1, Double _Value2)
        {
            Double result = _Value1 - _Value2;
            return result;
        }
        static Double Multiplication(Double _Value1, Double _Value2)
        {
            Double result = _Value1 * _Value2;
            return result;
        }
        static Double Division(Double _Value1, Double _Value2)
        {
            Double result = _Value1 / _Value2;
            if (_Value2 == 0)
            {
                Console.WriteLine("Division by zero is impossible");
            }
            return result;
        }
        static Double Modulus(Double _Value1, Double _Value2)
        {
            Double result = _Value1 % _Value2;
            return result;
        }
        static Double Power(Double _Value1, Double _Value2)
        {
            Double result = Math.Pow(_Value1, _Value2);
            return result;
        }
    }
}
