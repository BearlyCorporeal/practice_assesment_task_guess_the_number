using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random = r.Next(1, 25);
            int input = 0;
            int guessesleft = 7;
            int count = 0;
            string startinput;
            //List<int> guesses = new List<int>();  
            int[] guesses = new int[7];
            Console.WriteLine("Hey lets play a little guessing game.");
            Console.WriteLine("Guess the number between 0 and 25");
            while (count < 7) {
                startinput = Console.ReadLine();
                input = int.Parse(startinput);
                guesses[count] = input;
                //guesses.Add(input);
                if (input == random)
                {
                    Console.WriteLine("the number was indead "+ random);
                    Console.WriteLine("you guessed in " + count + " guesses");
                    Console.WriteLine("your guess log:");
                    Console.WriteLine("[");
                    foreach (int item in guesses)
                    {
                        Console.Write(item.ToString()+", ");
                    }
                   
                    Console.WriteLine("]");
                }
                if (input > random)
                {
                    Console.WriteLine("Nop, its less than that");
                    guessesleft = guessesleft - 1;
                    Console.WriteLine("you have " + guessesleft+" left!");
                }
                if (input < random)
                {
                    Console.WriteLine("Nop, its greater than that");
                    guessesleft = guessesleft - 1;
                    Console.WriteLine("you have " + guessesleft + " left!");
                }
                count = count + 1;
            }
            if (count == 7)
            {
                Console.WriteLine("the number was "+random+" you fool.");
                Console.WriteLine("log of guesses");
                foreach (int item in guesses)
                {
                    Console.Write(item.ToString() + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
