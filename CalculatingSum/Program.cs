using System;

namespace CalculatingSum
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number");
                double userNumber = Convert.ToDouble(Console.ReadLine());
                sum = sum + userNumber;
            }

            Console.WriteLine($"Your result is {sum}.");

        }
    }
}
