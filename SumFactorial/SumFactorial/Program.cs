using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number: ");
            var number = Console.ReadLine();
            var isNumber = int.TryParse(number, out int n);
            if (isNumber)
                Console.WriteLine(SumFactorial(ref n));
            else
                Console.WriteLine("Invalid number");

            Console.ReadLine();
        }

        static int SumFactorial(ref int i)
        {
            if (i <= 1)
                return 1;

            var n = i - 1;
            return i * SumFactorial(ref n);
        }
    }
}
