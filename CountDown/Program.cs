using System;
using System.Security.Principal;

namespace CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
