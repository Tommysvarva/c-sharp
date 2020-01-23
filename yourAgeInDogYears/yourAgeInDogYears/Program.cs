using System;


namespace yourAgeInDogYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate your age in dog years.");
            Console.WriteLine("Please enter your age...");
            var yourAge = Convert.ToInt32(Console.ReadLine());
            var yourAgeInDogYears = yourAge * 15;
            Console.WriteLine("You age in dog years is: " + yourAgeInDogYears);
            
        }
    }
}
