using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        public static bool IsPowerOfThree(int n)
        {

            double temp = n;

            if (n <= 0)
                return false;
            while (temp > 1)
            {
                temp /= 3;
            }
            if (temp == 1)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(27));
            Console.WriteLine(IsPowerOfThree(45));
            Console.ReadKey();
        }
    }
}
