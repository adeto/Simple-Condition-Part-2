using System;

namespace Excellent_or_Not
{
    class ExcelentOrNot
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            if (number >= 5.50)

            {
                Console.WriteLine("Excellent!");
            }

            else
            { 
                Console.WriteLine("Not Excellent.");

            }
        }
    }
}
