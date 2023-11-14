using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    
    internal class MultiplesHelper
    {
        public static List<int> getMultiples(int number, int quantity)
        {

            List<int> multiples = new List<int>();

            for (int i = 1; i <= quantity; i++)
            {
                int multiple = number * i;

                multiples.Add(multiple);
            }

            return multiples;
        }
    }
}
