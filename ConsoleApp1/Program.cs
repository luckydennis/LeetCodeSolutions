using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            int[] temp = new int[digits.Length + 1];
            digits[(digits.Length - 1)]++;
            if (digits[digits.Length - 1] > 9)
            {
                for (int i = 0; i <= digits.Length - 1; i++)
                {
                    temp[i] = digits[i];

                }
                temp[digits.Length - 1] = 1;
                temp[digits.Length] = 0;
            }
            return digits;

        }
        static void Main(string[] args)
        {
            int[] arr = { 9 };
            int [] temp =PlusOne(arr);
            foreach(int i in temp)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
