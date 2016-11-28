using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    public delegate void CalculatorDelegate(double firstArg, double secondArg);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Choose operation: \r\n 1.Addition \r\n 2.Substraction \r\n 3.Multiplication \r\n 4.Division");
            String operation = Console.ReadLine();

            switch (operation)
            {
                case "1": calculator.Calculations += new CalculatorDelegate(calculator.Addition);break;
                case "2": calculator.Calculations += new CalculatorDelegate(calculator.Substraction); break;
                case "3": calculator.Calculations += new CalculatorDelegate(calculator.Multiplication); break;
                case "4": calculator.Calculations += new CalculatorDelegate(calculator.Division); break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            
            calculator.DoEvent();

            Console.ReadKey();
        }

        private static void Calculator_Calculations(double firstArg, double secondArg)
        {
            throw new NotImplementedException();
        }
    }
    class Calculator
    {
        public event CalculatorDelegate Calculations;

        public void DoEvent()
        {          
            if (Calculations!=null)
            {
                Console.Write("Please enter first number: ");
                double firstArg = double.Parse(Console.ReadLine());
                Console.Write("Please enter second number: ");
                double secondArg = double.Parse(Console.ReadLine());
                Calculations(firstArg, secondArg);
            }
        }

        public void Addition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Addition result is: " + ($"{result}"));
        }
        public void Substraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Substraction result is: " + ($"{result}"));
        }
        public void Multiplication(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Multiplication result is: " + ($"{result}"));
        }
        public void Division(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Division result is: " + ($"{result}"));
        }
    }
}

