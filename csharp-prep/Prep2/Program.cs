using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade percent? ");
            string input = Console.ReadLine();
            int grade = int.Parse(input);

            string letter = "";

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
                {
                    letter = "B";
                }
            else if (grade >= 70)
                {
                    letter = "C";
                }
            else if (grade >= 60)
                {
                    letter = "D";
                }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is {letter}.");

            if (grade >= 70)
            {
                Console.WriteLine("You passed. Congratulations!");
            }

            else
            {
                Console.WriteLine("Sorry. Better luck next time.");
            }
        }
    }
}