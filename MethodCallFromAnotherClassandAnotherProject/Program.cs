using Divide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallFromAnotherClassandAnotherProject
{
    class Program
    {
        class CheckSum
        {
            public static int FindSum(int a, int b)
            {
                int result;

                result = a + b;

                return result;
            }
        }

        class TestSum
        {
            static void Main(string[] args)
            {
                int i;
                int y;
                int Sum;
                int mult;
                int Divide;
                Console.Write("Enter the num1:- ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the num2:- ");
                y = Convert.ToInt32(Console.ReadLine());

                // If we use Static keyword in method then for calling the method, we must be call method with class name like below:-

                Sum = CheckSum.FindSum(i, y);
                // If we don't use static then we Should be make class Object and after this we can call the method like below:-

                CalculatorMath calculator = new CalculatorMath();
                mult = calculator.FindMultiplication(i, y);

                // Here i call method from different project
                DivideNo divide = new DivideNo();
                Divide = divide.FindDivide(i, y);

                Console.Write("Sum of two numbers:- {0}", Sum);
                Console.WriteLine();
                Console.Write("Multiplication of two numbers:- {0}", mult);
                Console.WriteLine();
                Console.Write("Divide value:- {0}", Divide);

                Console.ReadLine();

            }
        }
    }
}
