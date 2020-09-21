using System;

namespace StringForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[6]);

            int stringLenght = helloWorld.Length;
            Console.WriteLine($"Your text is {stringLenght} symbols long.");
            char searchCriteria = 'o';
            int counter = 0;

            foreach(char letter in helloWorld)
            {
                if(letter == searchCriteria)
                {
                    counter += 1;
                }
            }

            Console.WriteLine($"There are {counter} Os in your text.");
        }
    }
}
