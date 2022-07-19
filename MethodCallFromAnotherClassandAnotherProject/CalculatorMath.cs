using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallFromAnotherClassandAnotherProject
{
    class CalculatorMath
    {
        public int FindMultiplication(int num1, int num2)
        {
            int result;
            result = num1 * num2;
            return result;
        }
    }
}
