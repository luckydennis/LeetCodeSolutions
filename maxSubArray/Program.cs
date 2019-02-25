using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSubArray
{
    class Program
    {
        //from discussion section explains about DP
        // break the problem into sub problems to solve the problem
        static int maxSubArray(int[] input)
        {
            int temp = input[0];

            for(int i =1; i<input.Length; i++)
            {
                if (input[i - 1] > 0)
                    input[i] += input[i - 1];

                temp = Math.Max(input[i], temp);
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int[] a = { -2,1,-3,4,-1,2,1,-5,4 };
            Console.WriteLine(maxSubArray(a));
            Console.ReadKey();
        }
    }
}
