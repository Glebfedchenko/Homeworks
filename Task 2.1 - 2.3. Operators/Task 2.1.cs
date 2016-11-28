using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 variable_1 = 2;
            //Int32 variable_2 = -3;

            ////addtive operators
            //Int32 sum = variable_1 + variable_2; //оператор сумы 
            //Int32 substraction = variable_1 - variable_2; //оператор вычитания

            ////multiplicative operators
            //Int32 multiplication = variable_2 * variable_1;//оператор умножения
            //Int32 division = variable_1 / variable_2;//оператор деления
            //Int32 modulus = variable_2 % variable_1;//оператор деления по модулю возвращает остачу от деления

            ////shift operators
            //Int32 shift_Fwd = variable_1 << variable_2;

            Int32 _A, _B, _C, _Res;
            _A = 10;
            _B = 20;
            _C = 30;
            //Multiplicative operators + additive operators + increment + decrement
            Console.WriteLine("Multiplicative operators usage example");
            _Res = _A + _B;
            Int32 _Res2 = _A - _B;
            Int32 _Res3 = _B * _B;
            Int32 _Res4 = _B / _B;
            Int32 _Modulus = _C % _B;
            Int32 _Increment = _A++;
            Int32 _Decrement = _B--;
            Int32 _Additive = _A << _B;
            Console.WriteLine("Multiplicative operators results are: " + "; sum = " + _Res + "; substraction = " + _Res2 + "; multiplication = " + _Res3 + "; division = " + _Res4 + "; modulus = " + _Modulus);
            Console.WriteLine("Increment = " + _Increment + "Decrement = " + _Decrement);
            Console.WriteLine("________________________________________________________________________________");

            // Logical operators + Conditional operators
            Console.WriteLine("Logical operators usage example");
            if (_A < _B)
            {
                _Res = _B + _C;
                Console.WriteLine("res variable value changes to 20 + 30 = " + _Res);
            }
            if (_A < _B && _C > _B)
            {
                _Res = _C - _A;
                Console.WriteLine("res variable value changes to 30 - 10 = " + _Res);
            }
            if (_A != _C || _A != _B)
            {
                _Res = _A++;
                Console.WriteLine("as variable a value is not c or b value: res variable = a + 1 =" + _Res);
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.ReadKey();
        }
    }
}
