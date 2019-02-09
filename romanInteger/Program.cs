using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanInteger
{
    class Program
    {
        public static int RomanToInt(string s)
        {
            int preVal = 0;
            int value = 0;
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        value = 1;
                        break;
                    case 'V':
                        value = 5;
                        break;
                    case 'X':
                        value = 10;
                        break;
                    case 'L':
                        value = 50;
                        break;

                    case 'C':
                        value = 100;
                        break;
                    case 'D':
                        value = 500;
                        break;
                    case 'M':
                        value = 1000;
                        break;
                    default:
                        break;
                }
                sum += value;
                if (preVal < value && i > 0)
                {
                    sum -= preVal*2;
                }


                preVal = value;


            }
            return sum;
        }
            static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IX"));
            Console.ReadKey();
        }
    }
}
