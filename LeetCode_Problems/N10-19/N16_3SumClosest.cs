using System.Text;

namespace LeetCode_Problems
{
    public class N16_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            nums = [.. nums.Order()];

            int left, right, current = 0;
            int minDiff = int.MaxValue;
            int closestSum = 0;

            while (current < nums.Length - 2)
            {
                left = current + 1;
                right = nums.Length - 1;

                int lastDiff = int.MaxValue;

                for (int i = left; i < right; i++)
                {
                    for (int j = right; j > left; j--)
                    {
                        int sum = nums[current] + nums[i] + nums[j];
                        int currentDiff = Math.Abs(target - sum);

                        if (currentDiff < minDiff)
                        {
                            minDiff = currentDiff;
                            closestSum = sum;
                            lastDiff = currentDiff;
                        }
                        else if (currentDiff > lastDiff)
                        {
                            break;
                        }
                    }
                }

                current++;
            }

            return closestSum;
        }
    }
}
