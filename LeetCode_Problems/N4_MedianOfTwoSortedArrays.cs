using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class N4_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            
        }

        private int[] GetMedianValues(int[] nums)
        {
            if (nums.Length % 2 == 0)
            {
                int medianIndex2 = nums.Length / 2;
                return [nums[medianIndex2 - 1], nums[medianIndex2]];
            }
            else
            {
                return [nums[(nums.Length - 1) / 2]];
            }
        }

        private int? TryGetMedian(int[] medianValues1, int[] medianValues2)
        {
            if (medianValues1.Length == 2 && medianValues2.Length == 2)
            {

            }
        }
    }
}
