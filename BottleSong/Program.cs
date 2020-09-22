using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            for(int i = 100; i > 74; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall.");
                Console.WriteLine($"{i} bottles of beer!");
                Console.WriteLine("Take One Down.");
                Console.WriteLine("Pass it around.");
                Console.WriteLine($"{i-1} bottles of beer on the wall.");

            }
        }
    }
}
