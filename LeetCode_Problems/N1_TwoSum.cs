namespace LeetCode_Problems
{
    //https://leetcode.com/problems/two-sum/description/
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    public class N1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> pairs = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (pairs.ContainsValue(diff))
                {
                    return [pairs.First(p => p.Value == diff).Key, i];
                }
                else
                {
                    pairs.Add(i, nums[i]);
                }
            }
            return [];
        }

        //Бинарный поиск
        public int[] TwoSumOld(int[] nums, int target)
        {
            List<(int Index, int Value)> numsWithIndicies = new List<(int, int)>();
            for (int i = 0; i < nums.Length; i++)
            {
                numsWithIndicies.Add((i, nums[i]));
            }

            numsWithIndicies = numsWithIndicies.OrderBy(x => x.Value).ToList();

            int leftIndex = 0;
            int rightIndex = numsWithIndicies.Count - 1;
            int sum;

            while (numsWithIndicies[leftIndex].Value <= numsWithIndicies[rightIndex].Value)
            {
                sum = numsWithIndicies[leftIndex].Value + numsWithIndicies[rightIndex].Value;
                if (sum > target)
                {
                    rightIndex--;
                }
                else if (sum == target)
                {
                    return [numsWithIndicies[leftIndex].Index, numsWithIndicies[rightIndex].Index];
                }
                else
                {
                    leftIndex++;
                }
            }

            return [];
        }
    }
}
