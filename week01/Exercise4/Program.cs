using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0)
                    break;
                
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            int maxNumber = numbers.Max();
            Console.WriteLine($"The largest number is: {maxNumber}");

            int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
            if (smallestPositive > 0)
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
                Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
