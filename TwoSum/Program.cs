using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
                return null;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int temp = nums[i] + nums[j];
                    if (temp == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 4 };
            foreach(var x in TwoSum(test, 8))
                Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
