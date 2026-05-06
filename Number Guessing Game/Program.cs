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
            int chances = 0;
            int top = 13;
            bool gameOver = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.\n");

            Console.WriteLine("Please select the difficulty level: ");
            Console.WriteLine("1. Easy (10 chances)");
            Console.WriteLine("2. Medium (5 chances)");
            Console.WriteLine("3. Hard (3 chances)\n");

            Console.WriteLine("Enter your choice: ");
            Console.SetCursorPosition(19, 8);
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
                            Console.WriteLine("\nEnter your guess: ");
                            Console.SetCursorPosition(18, top);
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
                                gameOver = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            gameOver = true;
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
                            Console.WriteLine("\nEnter your guess: ");
                            Console.SetCursorPosition(18, top);
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
                                gameOver = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            gameOver = true;
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
                            Console.WriteLine("\nEnter your guess: ");
                            Console.SetCursorPosition(18, top);
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
                                gameOver = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Over! You've used all your chances. The correct number was " + ran + ".");
                            gameOver = true;
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
}
