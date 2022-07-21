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
        }
    }
}
