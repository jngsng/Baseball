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

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] guesses = new int[3];
            string[] input_message = { " > Input First Number", " > Input Second Number", " > Input Third Number" };

            while (true)
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine(input_message[i]);
                    guesses[i] = int.Parse(Console.ReadLine());
                }

                if (guesses[0] == guesses[1] || guesses[1] == guesses[2] || guesses[0] == guesses[2])
                {
                    Console.WriteLine("Same Number");
                    continue;
                }
                else
                {
                    Console.WriteLine(" > Input Numbers");
                    for(int j = 0; j < 3; j++)
                    {
                        Console.WriteLine(guesses[j]);
                    }

                    int strikeCount = 0;
                    int ballCount = 0;

                    for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if(guesses[i] == numbers[j])
                            {
                                if(i == j)
                                {
                                    strikeCount++;
                                }

                                else
                                {
                                    ballCount++;
                                }
                            }
                        }
                    }

                    Console.Write("Strike : ");
                    Console.WriteLine(strikeCount);
                    Console.Write("Ball : ");
                    Console.WriteLine(ballCount);
                    Console.Write("Out : ");
                    Console.WriteLine(3 - strikeCount - ballCount);

                    if (strikeCount == 3)
                    {
                        Console.WriteLine("CORRECT!");
                        break;
                    }
                }
            }

        }
    }
}
