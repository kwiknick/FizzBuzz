using System;
using fizzbuzz.library;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzzer = new FizzBuzzer();
            int range;

            if (args.Length == 1)
            {
                Int32.TryParse(args[0], out range);
            }
            else
            {
                range = 100;
            }

            for (var i = 1; i <= range; i++) 
            {
                Console.WriteLine(fizzbuzzer.DetermineIsDivisable(i));
            }

            Console.ReadLine();
        }
    }
}
