using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseInt
{
    
    class Program
    {
        public static int Reverse(int x)
        {
            bool flag = false;
            //int flag = 1;
            //if(x<0)
            //flag *= -1;
            if (x < 0)
            {
                if (x == -2147483648)
                    x += 1;
                x *= -1;
                flag = true;
            }
            string strInt = x.ToString();
            char[] tempArr = strInt.ToCharArray();
            int length = tempArr.Length / 2;

            for (int i = 0; i < tempArr.Length / 2; i++)
            {
                int val = tempArr.Length - i - 1;
                char temp = tempArr[i];
                tempArr[i] = tempArr[val];
                tempArr[val] = temp;
            }

            string str2 = new string(tempArr);
            try
            {

                int temp2 = Int32.Parse(str2);
                if (flag)
                {
                    return temp2 * -1;
                }
                else
                    return temp2;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1234));

            Console.WriteLine(Reverse(689234));
            Console.WriteLine(Reverse(-1234));
            Console.ReadKey();

        }
    }
}
