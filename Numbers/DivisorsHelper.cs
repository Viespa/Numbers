using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class DivisorsHelper
    {
        public static List<int> getDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }
    }
}
