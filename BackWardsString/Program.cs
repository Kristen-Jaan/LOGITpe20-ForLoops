using System;

namespace BackWardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string name = "Harry";
            Console.WriteLine(name[4]);
            
            for(int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
                
            

        }
    }
}
