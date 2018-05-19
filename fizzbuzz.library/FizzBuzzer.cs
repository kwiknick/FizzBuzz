using System;

namespace fizzbuzz.library
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string DetermineIsDivisable(int number)
        {
            if (number % 15 == 0)
            {
                return DivisableByThreeAndFive(number);
            }
            else if (number % 5 == 0)
            {
                return DivisableByFive(number);
            }
            else if (number % 3 == 0)
            {
                return DivisableByThree(number);
            }
            else
            {
                return NotDivisableByFiveOrThree(number);
            }
        }
        
        public string DivisableByFive(int number) 
        {
            return "buzz";
        }

        public string DivisableByThree(int number)
        {
            return "fizz";
        }

        public string DivisableByThreeAndFive(int number)
        {
            return "fizzbuzz";
        }

        public string NotDivisableByFiveOrThree(int number)
        {
            return number.ToString();
        }
    }
}