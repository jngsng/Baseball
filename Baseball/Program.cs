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
            int number1 = 3;
            int number2 = 1;
            int number3 = 9;

            Console.WriteLine(" > Input First Number");
            int guess1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" > Input Second Number");
            int guess2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" > Input Third Number");
            int guess3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" > Input Numbers");
            Console.WriteLine(guess1);
            Console.WriteLine(guess2);
            Console.WriteLine(guess3);

            int strikeCount = 0;
            int ballCount = 0;

            // guess1
            if(guess1 == number1)
            {
                strikeCount = strikeCount + 1;
            }
            else if (guess1 == number2 || guess1 == number3)
            {
                ballCount = ballCount + 1;
            }

            // guess2
            if (guess2 == number2)
            {
                strikeCount = strikeCount + 1;
            }
            else if (guess2 == number1 || guess2 == number3)
            {
                ballCount = ballCount + 1;
            }

            // guess3
            if (guess3 == number3)
            {
                strikeCount = strikeCount + 1;
            }
            else if (guess3 == number2 || guess3 == number1)
            {
                ballCount = ballCount + 1;
            }
        }
    }
}
