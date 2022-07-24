using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("=========================BASEBALL=========================");
            Console.WriteLine("==========================================================");

            Console.WriteLine("NUMBERS");
            int[] numbers = { 3, 1, 9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            int[] guesses = new int[3];

            while (true)
            {
                Console.WriteLine(" > Input First Number");
                guesses[0] = int.Parse(Console.ReadLine());
                Console.WriteLine(" > Input Second Number");
                guesses[1] = int.Parse(Console.ReadLine());
                Console.WriteLine(" > Input Third Number");
                guesses[2] = int.Parse(Console.ReadLine());

                if (guesses[0] == guesses[1] || guesses[1] == guesses[2] || guesses[0] == guesses[3])
                {
                    Console.WriteLine("Same Number");
                    continue;
                }
                else
                {
                    Console.WriteLine(" > Input Numbers");
                    Console.WriteLine(guesses[0]);
                    Console.WriteLine(guesses[1]);
                    Console.WriteLine(guesses[2]);

                    int strikeCount = 0;
                    int ballCount = 0;

                    // guess1
                    if (guesses[0] == numbers[0])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guesses[0] == numbers[1] || guesses[0] == numbers[2])
                    {
                        ballCount = ballCount + 1;
                    }

                    // guess2
                    if (guesses[1] == numbers[1])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guesses[1] == numbers[0] || guesses[1] == numbers[2])
                    {
                        ballCount = ballCount + 1;
                    }

                    // guess3
                    if (guesses[2] == numbers[2])
                    {
                        strikeCount = strikeCount + 1;
                    }
                    else if (guesses[2] == numbers[1] || guesses[2] == numbers[0])
                    {
                        ballCount = ballCount + 1;
                    }

                    Console.Write("Strike : ");
                    Console.WriteLine(strikeCount);
                    Console.Write("Ball : ");
                    Console.WriteLine(ballCount);
                    Console.Write("Out : ");
                    Console.WriteLine(3 - strikeCount - ballCount);

                    if (guesses[0] == numbers[0] && guesses[1] == numbers[1] && guesses[2] == numbers[2])
                    {
                        Console.WriteLine("CORRECT!");
                        break;
                    }
                }
            }

        }
    }
}
