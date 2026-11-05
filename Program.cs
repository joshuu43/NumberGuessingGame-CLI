using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class game
    {
        public void restart()
        {
            Console.WriteLine("\nDo you want to play again? (y/n)");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Thank you for playing! Goodbye.");
                Environment.Exit(0);
            }
        }

        public void Start()
        {
            Random random = new Random();
            int ran = random.Next(1, 101);
            int difficulty;
            int chances = 0;
            int top = 13;
            bool gameOver = false;
            
            Console.Clear();
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.\n");

            Console.WriteLine("Please select the difficulty level: ");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)\n");

            Console.Write("Enter your choice: ");
            int.TryParse(Console.ReadLine(), out difficulty);

            switch (difficulty)
            {
                case 1:
                    Console.WriteLine("\nGreat! You have selected the Easy difficulty level.");
                    Console.WriteLine("Let's start the game!");

                    while (!gameOver)
                    {
                        if (chances != 10)
                        {
                            Console.Write("\nEnter your guess: ");
                            int guess = int.Parse(Console.ReadLine());

                            if (guess < ran)
                            {
                                Console.WriteLine("Incorrect! The number is greater than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else if (guess > ran)
                            {
                                Console.WriteLine("Incorrect! The number is less than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else
                            {
                                chances++;
                                Console.WriteLine("Congratulations! You guessed the correct number in " + chances + " attempts.");
                                restart();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            restart();
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("\nGreat! You have selected the Medium difficulty level.");
                    Console.WriteLine("Let's start the game!");

                    while (!gameOver)
                    {
                        if (chances != 5)
                        {
                            Console.Write("\nEnter your guess: ");
                            int guess = int.Parse(Console.ReadLine());

                            if (guess < ran)
                            {
                                Console.WriteLine("Incorrect! The number is greater than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else if (guess > ran)
                            {
                                Console.WriteLine("Incorrect! The number is less than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else
                            {
                                chances++;
                                Console.WriteLine("Congratulations! You guessed the correct number in " + chances + " attempts.");
                                restart();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            restart();
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine("\nGreat! You have selected the Hard difficulty level.");
                    Console.WriteLine("Let's start the game!");

                    while (!gameOver)
                    {
                        if (chances != 3)
                        {
                            Console.Write("\nEnter your guess: ");
                            int guess = int.Parse(Console.ReadLine());

                            if (guess < ran)
                            {
                                Console.WriteLine("Incorrect! The number is greater than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else if (guess > ran)
                            {
                                Console.WriteLine("Incorrect! The number is less than " + guess + ".");
                                top += 3;
                                chances++;
                            }
                            else
                            {
                                chances++;
                                Console.WriteLine("Congratulations! You guessed the correct number in " + chances + " attempts.");
                                restart();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            restart();
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    chances = 10;
                    break;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            game gameInstance = new game();

            if (args.Length == 0)
            {
                Console.WriteLine("Enter a command. Use --help to see the options.");
                return;
            }

            string comando = args[0].ToLowerInvariant();

            if (comando == "start")
            {
                gameInstance.Start();
            }
            else if (comando == "--help")
            {
                Console.WriteLine("Available commands:");
                Console.WriteLine("start - Start the number guessing game.");
                Console.WriteLine("--help - Show this help message.");
            }
            else
            {
                Console.WriteLine("Invalid command. Please use 'start' to begin the game.");
            }
        }
    }
}
