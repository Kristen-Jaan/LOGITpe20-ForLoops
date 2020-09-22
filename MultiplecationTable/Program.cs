using System;

namespace MultiplecationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter a number: ");
            int userNumber = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
            }
            for(int i = 11; i >= 1; i--)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
            }
        }
    }
}
