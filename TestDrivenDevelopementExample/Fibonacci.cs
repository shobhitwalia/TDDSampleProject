using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopementExample
{
    public class Fibonacci
    {
        public static int GetFibonacciNumber(int number)
        {
            /*
            Step 1 : 
            return 0;

            Step 2:
            if (number == 0)
                return 0;
            else 
                return 1;

            Step 3:
          
            if (number == 0)
                return 0;
            else if (number <= 2)
                return 1;
            else 
                return 2;
             */

            if (number == 0)
                return 0;
            if (number < 0)
                throw new IndexOutOfRangeException();
            else if (number <= 2)
                return 1;
            else
                return GetFibonacciNumber(number - 1) + GetFibonacciNumber(number - 2);

        }
    }
}
