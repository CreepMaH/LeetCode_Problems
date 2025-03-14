using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("Tests")]
namespace LeetCode_Problems.N20_29
{
    internal class N26_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int lastIndexOfUnique = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    lastIndexOfUnique++;
                    nums[lastIndexOfUnique] = nums[i];
                }
            }

            return lastIndexOfUnique + 1;
        }
    }
}
