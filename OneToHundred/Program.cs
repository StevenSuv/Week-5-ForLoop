using System;

namespace OneToHundredAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+1);
            }
            for (int i = 98; i > -1; i--)
            {
                Console.WriteLine(i+1);
            }
            Console.ReadLine();
        }
    }
}
