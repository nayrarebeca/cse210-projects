using System;
using System.Collections.Generic;
using System.Linq;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            int number = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            number = -1;

            while (number != 0)
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                    numbers.Add(number);
            }

            //The list "numbers" now has all the numbers the user typed

            //Step 1: Find the sum or total
            
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Step 2: Find the average
            // We can use the sum we just computed...
            int average = sum / numbers.Count;

            Console.WriteLine($"The average is: {average}");

            // Step 3: Find the max
            // We will walk through the numbers again, this time keeping track
            // of the best so far, or the highest number to that point.

            int bestSoFar = numbers.AsQueryable().Max();

            // foreach (int num in numbers)
            //     // Check if this number is larger than the best one we have seen so far
            //     if (number > bestSoFar)
            //         // This is the new best number, so save it to that variable
            //         {
            //             bestSoFar = number;
            //         }

            Console.WriteLine($"The largest number is: {bestSoFar}");

            // Stretch Challenges

            // Stretch Challenge 1: Find the smallest positive number:

            // We need to start with something large
            long smallestSoFar = numbers.AsQueryable().Min();

            // Note: If we wanted to be the most accurate here, instead of starting with a big
            // number like above, we should loop through the list until we find a positive number
            // and use that as the smallest_so_far. I'm going with the approach here, because it's
            // simpler to see and understand, but what if the list didn't have any positive numbers?
            // What if it didn't have any less than the big number I picked? These would create
            // problems that would be solved by the approach mentioned.

            // foreach (int num in numbers)
            // {
            //     if (number > 0 && number < smallestSoFar)
            //         // We have a new smallest number
            //         {
            //             smallestSoFar = number;
            //         }
            // }

            Console.WriteLine($"The smallest positive number is: {smallestSoFar}");

            // Stretch Challenge 2: Sorting the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
        }
    }
}
