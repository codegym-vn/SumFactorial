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
            var n = 5;
            Console.WriteLine(SumFactorial(ref n));
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
