using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeDup
{
    class Program
    {
        //public static int RemoveDuplicates(int[] nums)
        //{
        //    int finalLength = 1;
        //    int x;
        //    if (nums.Length == 0)
        //        return 0;
        //    for (x = 0; x < nums.Length - 2; x++)
        //    {
        //        //try{
        //        int counter = 0;
        //        int temp = x;
        //        while (nums[temp] == nums[temp + 1]  || nums[temp] > nums[temp+1])
        //        {
        //            if(x>0)
        //            {
        //                while(nums[x] > nums[temp+1])
        //                {
        //                    counter++;
        //                    if (temp + 1 < nums.Length -1)
        //                    temp++;
        //                }
        //            }
        //            counter++;
        //            if (temp + 1 < nums.Length -1)
        //                temp++;
        //            if ((counter + x + 1 > nums.Length))
        //                return finalLength;
        //        }
        //        try
        //        {
        //            if (nums[x] < nums[x + counter + 1])
        //            {
        //                nums[x + 1] = nums[x + counter + 1];
        //            }
        //            finalLength++;
        //        }
        //        catch(IndexOutOfRangeException)
        //        {
        //            return finalLength;
        //        }
        //        //}
        //        //catch(IndexOutOfRangeException)
        //        //{
        //        //    return finalLength+1;
        //        //}
        //    }
        //if(nums.Length>2)
        //{
        //if (nums[nums.Length - 2] < nums[nums.Length - 1])
        //        return finalLength+1;
        //    else
        //        return finalLength;
        //}else return finalLength;
        //}

        //not mine============================
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                    continue;
                nums[++i] = nums[j];
            }
            return i + 1;
        }
        //===============================
        static void Main(string[] args)
        {
            int[] arr = { 0,0,1,1,1,2,2,3,3,4 };
            int[] arr2 = { 1, 2,3 };
            RemoveDuplicates(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
