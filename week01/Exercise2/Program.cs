using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        Console.Write("This determines your grade! Enter your score: ");
        string scoreFromUser = Console.ReadLine();

        if (int.TryParse(scoreFromUser, out int x))
        {
            if (x >= 94)    
            {
                Console.WriteLine("Your grade is A.");
            }
            else if (x >= 90)
            {
                Console.WriteLine("Your grade is A-.");
            }
            else if (x >= 87)
            {
                Console.WriteLine("Your grade is B+.");
            }
            else if (x >= 84)
            {
                Console.WriteLine("Your grade is B.");
            }
            else if (x >= 80)
            {
                Console.WriteLine("Your grade is B-.");
            }
            else if (x >= 77)
            {
                Console.WriteLine("Your grade is C+.");
            }
            else if (x >= 74)
            {
                Console.WriteLine("Your grade is C.");
            }
            else if (x >= 70)
            {
                Console.WriteLine("Your grade is C-.");
            }
            else if (x >= 67)
            {
                Console.WriteLine("Your grade is D+.");
            }
            else if (x >= 64)
            {
                Console.WriteLine("Your grade is D.");
            }
            else if (x >= 60)
            {
                Console.WriteLine("Your grade is D-.");
            }
            else
            {
                Console.WriteLine("Your grade is F.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid integer score.");
        }
        
        if ( x > 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You do not passed");
        }
    }
}
