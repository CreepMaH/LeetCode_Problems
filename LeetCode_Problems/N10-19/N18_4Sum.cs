using System.Net.Quic;
using System.Text;

namespace LeetCode_Problems
{
    public class N18_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            nums = [.. nums.OrderBy(x => x)];

            IList<IList<int>> quadruplets = [];
            int left, right, inner, outer;
            left = right = inner = outer = 0;
            
            while (outer < nums.Length - 3)
            {
                inner = outer + 1;

                while (inner < nums.Length - 2)
                {
                    left = inner + 1;
                    right = nums.Length - 1;

                    while (left < right)
                    {
                        long edgesSum = (long)nums[outer] + nums[inner] + nums[left] + nums[right];
                        if (edgesSum == target)
                        {
                            List<int> result = [nums[outer], nums[inner], nums[left], nums[right]];
                            quadruplets.Add(result);

                            while (nums[left] == result[2] && left < right)
                            {
                                left++;
                            }
                            while (nums[right] == result[3] && right > left)
                            {
                                right--;
                            }
                        }
                        else if (edgesSum > target)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }

                    int currentInner = nums[inner];

                    while (nums[inner] == currentInner && inner < nums.Length - 2)
                    {
                        inner++;
                    }
                }

                int currentOuter = nums[outer];

                while (nums[outer] == currentOuter && outer < nums.Length - 3)
                {
                    outer++;
                }
            }
            
            return quadruplets;
        }
    }
}
