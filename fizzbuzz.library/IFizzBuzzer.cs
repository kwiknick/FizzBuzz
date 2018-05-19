using System;

namespace fizzbuzz.library
{
    public interface IFizzBuzzer 
    {
        string DetermineIsDivisable(int number);
        string DivisableByFive(int number);
        string DivisableByThree(int number);
        string DivisableByThreeAndFive(int number);
        string NotDivisableByFiveOrThree(int number);
    }
}