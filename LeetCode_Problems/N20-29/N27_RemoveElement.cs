using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("Tests")]
namespace LeetCode_Problems.N20_29
{
    internal class N27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int diffsCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[diffsCount] = nums[i];
                    diffsCount++;
                }
            }

            return diffsCount;
        }
    }
}
