using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string firstname;
            firstname = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastname;
            lastname = Console.ReadLine();

            Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
        }
    }
}
