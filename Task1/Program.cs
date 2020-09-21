using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine();
            int counter = 0;

            foreach(char letter in userInput)
            {
                Console.WriteLine(letter);
                counter = counter + 1;
                Console.WriteLine($"letter {letter} is at {counter}");
            }
            Console.WriteLine($"Your name is {counter} characters long.");
        }
    }
}
