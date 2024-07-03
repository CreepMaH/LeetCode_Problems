namespace LeetCode_Problems
{
    //https://leetcode.com/problems/two-sum/description/
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    public class N1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
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

        public int[] TwoSumFromSolutions(int[] nums, int target)
        {
            var m = new Dictionary<int, int>();
            var x = nums.Select((v, i) => (i, v);

            foreach (var (i, v) in nums.Select((v, i) => (i, v)))
            {
                try { return new int[] { i, m[target - v] }; }
                catch (KeyNotFoundException) { m[v] = i; }
            }
            throw new Exception("never");
        }
    }
}
