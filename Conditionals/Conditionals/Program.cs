using System;
using System.Runtime.CompilerServices;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string more = "y";

            do
            {
                Console.WriteLine("Enter in a number between 1 and 100");
                int choice = Validation(int.Parse(Console.ReadLine()));
                if (choice % 2 == 1)
                {
                    Console.WriteLine($"{choice} Odd");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    more = Validation(Console.ReadLine());
                }
                else if (choice % 2 == 0 && choice < 25)
                {
                    Console.WriteLine($"{choice} Even and Less than 25");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    more = Validation(Console.ReadLine());
                }
                else if (choice % 2 == 0 && choice > 24 && choice < 60)
                {
                    Console.WriteLine($"{choice} Even");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    more = Validation(Console.ReadLine());
                }
                else if (choice % 2 == 0 && choice > 60)
                {
                    Console.WriteLine($"{choice} Even");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    more = Validation(Console.ReadLine());
                }
            } while (more == "y");

            Console.WriteLine("Goodbye!");

        }

        static int Validation(int input)
        {
            string tryAgain = "y";
            while (tryAgain == "y")
            {
                if (input < 100 && input > 1)
                {
                    tryAgain = "n";
                }
                else
                {
                    Console.WriteLine("Please enter a valid input (1-100)");
                    input = int.Parse(Console.ReadLine());
                }
            }

            return input;
        }

        static string Validation(string input)
        {
            string go = "y";

            do
            {
                if (input == "y" || input == "n")
                {
                    go = "n";
                }
                else
                {
                    Console.WriteLine("Please enter valid input (y/n)");
                    input = Console.ReadLine();
                }
            } while (go == "y");

            return input;
        }
    }
}
