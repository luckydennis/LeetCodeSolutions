using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeElement
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int pre = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    continue;
                nums[pre] = nums[i];
                pre++;


            }
            return pre;
        }
        static void Main(string[] args)
        {

            int[] arr = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            RemoveElement(arr, val);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }
    }
}
