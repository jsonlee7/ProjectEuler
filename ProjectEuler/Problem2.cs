using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem2
    {
        public static int CalculateSumEvenNumberFibonacciLessThan4Million()
        {
            int sum = 0;
            int prevFib = 1;
            int currentFib = 2;
            int nextFib = 0;

            do
            {
                if (currentFib % 2 == 0)
                    sum += currentFib;

                nextFib = prevFib + currentFib; 
                prevFib = currentFib;
                currentFib = nextFib;                
                

            } while (currentFib < 4000000);


            return sum;
        }
    }
}
