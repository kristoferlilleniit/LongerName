using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LongerName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first name:");
            string nameOne = Console.ReadLine();
            Console.WriteLine("enter the second name: ");
            string nameTwo = Console.ReadLine();
            int lengthOne = 0;
            int lengthTwo = 0;
            foreach (char letter in nameOne)
            {
                lengthOne = lengthOne + 1;
            }

            foreach (char letter in nameTwo)
            {
                lengthTwo = lengthTwo + 1;
            }
            if (lengthOne > lengthTwo)
            {
                Console.WriteLine("Name one is the longest.");
            }else if(lengthOne < lengthTwo)
            {
                Console.WriteLine("Name two is the longest.");
            }else
            {
                Console.WriteLine("Both names are of the same lenght.");
            }
        }
    }
}
