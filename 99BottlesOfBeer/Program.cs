using System;

namespace _99BottlesOfBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 98; i > -2; i--)
            {
                if (i == -1)
                {
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. \nGo to the store and buy some more, 99 bottles of beer on the wall...");
                }
                else
                {
                    Console.WriteLine($"{i + 1} Bottles of beer on the wall, {i + 1} bottles of beer. \nTake one down and pass it around, {i} bottles of beer on the wall.\n");
                }
            }
            Console.ReadLine();
        }
    }
}
