using System.Text;

namespace LeetCode_Problems
{
    public class N15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            nums = [.. nums.OrderBy(x => x)];

            IList<IList<int>> triplets = [];
            int left, right, current = 0;

            while (current < nums.Length - 2)
            {
                left = current + 1;
                right = nums.Length - 1;

                int target = -nums[current];

                while (left < right)
                {
                    int edgesSum = nums[left] + nums[right];
                    if (edgesSum == target)
                    {
                        List<int> result = [nums[left], nums[current], nums[right]];
                        triplets.Add(result);

                        while (nums[left] == result[0] && left < right)
                        {
                            left++;
                        }
                        while (nums[right] == result[2] && right > left)
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

                int currentNum = nums[current];
                
                while (nums[current] == currentNum && current < nums.Length - 2)
                {
                    current++;
                }
            }

            return triplets;
        }
    }
}
