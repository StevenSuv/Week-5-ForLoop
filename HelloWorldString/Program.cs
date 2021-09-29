using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            for(int i = 0; i < helloWorld.Length; i++)
            {
                Console.WriteLine($"In slot {i+1} is {helloWorld[i]}");
            }
        }
    }
}
