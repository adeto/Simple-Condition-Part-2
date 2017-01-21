using System;

namespace Even_or_Odd
{
    class EvenOrOdd
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
