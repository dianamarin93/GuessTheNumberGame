using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Play_Game();
        }

        public static void Play_Game()
        {
            Random rnd = new Random();
            int hiddenNumber = rnd.Next(100);
            int counter = 0;
            int lives = 7;
            int easterEgg = -1;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Guess the number!");
                Console.ForegroundColor = ConsoleColor.Black;

                int number = Convert.ToInt32(Console.ReadLine());

                if (number == -1)
                {
                    lives += 3;
                    Console.WriteLine("You found an EasterEgg and you received 3 extra lives");
                }

                counter++;

                if (number < hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("More! ");
                    lives--;
                }
                else if (number > hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Less!");
                    lives--;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Congratulations! You guessed the number using {counter} attempts");
                    break;
                }
            }
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
    }
}
