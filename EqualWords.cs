using System;

namespace _12.Equal_Words
{
    class EqualWords
    {
        static void Main()
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
