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

            Console.WriteLine(" > Input First Number");
            int guess1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" > Input Second Number");
            int guess2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" > Input Third Number");
            int guess3 = int.Parse(Console.ReadLine());

            if(guess1 == guess2 || guess2 == guess3 || guess1 == guess3)
            {
                Console.WriteLine("Same Number");
            }
            else
            {
                Console.WriteLine(" > Input Numbers");
                Console.WriteLine(guess1);
                Console.WriteLine(guess2);
                Console.WriteLine(guess3);

                int strikeCount = 0;
                int ballCount = 0;

                // guess1
                if (guess1 == numbers[0])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess1 == numbers[1] || guess1 == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                // guess2
                if (guess2 == numbers[1])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess2 == numbers[0] || guess2 == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                // guess3
                if (guess3 == numbers[2])
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess3 == numbers[1] || guess3 == numbers[0])
                {
                    ballCount = ballCount + 1;
                }

                Console.Write("Strike : ");
                Console.WriteLine(strikeCount);
                Console.Write("Ball : ");
                Console.WriteLine(ballCount);
                Console.Write("Out : ");
                Console.WriteLine(3 - strikeCount - ballCount);
            }
        }
    }
}
