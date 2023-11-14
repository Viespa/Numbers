using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class FactoringHelper
    {
        public static List<int> FactoringNumber(int number)
        {
            List<int> factoring = new List<int>();

            int divisor = 2;

            while (number > 1)
            {
                if(number % divisor == 0)
                {
                    factoring.Add(divisor);
                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return factoring;

        }
    }
}
