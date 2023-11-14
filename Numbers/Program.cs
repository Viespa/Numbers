namespace Numbers
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int number = 0;
            int option = 0;
            int quantity = 0;
            List<int> result = new List<int>();


            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to know the multiples or divisors?");
            Console.WriteLine("1) Multiples");
            Console.WriteLine("2) Divisors");
            Console.WriteLine("3) Factor");
            option = Convert.ToInt32(Console.ReadLine());


            switch(option)
            {
                case 1:
                    //Multiples
                    Console.Write("Insert up to which number you want to know the multipliers: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    result = Numbers.MultiplesHelper.getMultiples(number, quantity);

                    Console.WriteLine($"The first {quantity} multiples of {number} are: {string.Join(", ", result)}");
                    break;
                case 2:
                    //Divisors
                    result = Numbers.DivisorsHelper.getDivisors(number);

                    Console.WriteLine($"These are the divisors of {number}: {string.Join(", ", result)}");
                  break;
                case 3:

                    result = Numbers.FactoringHelper.FactoringNumber(number);

                    Console.WriteLine($"The prime factors of {number} are : {string.Join(", ", result)}");

                    break;

            }
        }
    }
}
