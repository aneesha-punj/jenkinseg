using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodility
{
    class KthLargest
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    count++;
                }
                if (count == (k - 1))
                {
                    return nums[i];
                }

            }
            return nums[nums.Length];
        }
        static void Main(string[] args)
        {

        }
    }
}
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);

        if (nums[i] < nums[i + 1])
        {
            return nums[nums.Length - k];
        }
        else
        {
            int[] dist = nums.Distinct().ToArray();
            return dist[dist.Length - k];
        }


    }
}
