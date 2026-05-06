using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ran = random.Next(1, 101);
            int difficulty;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.\n");

            Console.WriteLine("Please select the difficulty level: ");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)\n");

            Console.WriteLine("Enter your choice: ");
            Console.SetCursorPosition(19, 8);
            difficulty = int.Parse(Console.ReadLine());

        }
    }
}
