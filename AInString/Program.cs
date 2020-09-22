using System;

namespace AInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine().ToLower();
            char searchCriteria = 'a';
            int counter = 0;
            for(int i = 0; i < userInput.Length; i++)
            {
                if(userInput.ToLower()[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }
            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} As in your name.");
            }
            else
            {
                Console.WriteLine($"There are no As in your name.");
            }





        }
    }
}
