using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum number to check for perfect numbers:");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= max; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i + " is a perfect number.");
                }
            }
        }
    }
}