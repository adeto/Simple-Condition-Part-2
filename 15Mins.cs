using System;

namespace _15.Time__15_Minutes
{
    class Program
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            var sum = ((num1 * 60) + num2 + 15);
            var resulthour = sum / 60;
            if (resulthour >= 24)
            {
                resulthour -= 24;
            }
            var resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);
       

        }
    }
}
