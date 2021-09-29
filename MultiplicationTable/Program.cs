using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {userNumber} = {i * userNumber}");
            }
            Console.ReadLine();

        }
    }
}
