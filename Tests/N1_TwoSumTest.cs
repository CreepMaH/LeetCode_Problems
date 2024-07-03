using LeetCode_Problems;

namespace Tests
{
    public class N1_TwoSumTest
    {
        private N1_TwoSum _n1_TwoSum;

        [SetUp]
        public void Setup()
        {
            _n1_TwoSum = new N1_TwoSum();
        }

        [Test]
        public void Test1()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            int[] result = _n1_TwoSum.TwoSum(nums, target);
            int[] expected = [0, 1];

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;

            int[] result = _n1_TwoSum.TwoSum(nums, target);
            int[] expected = [1, 2];

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            int[] nums = [3, 3];
            int target = 6;

            int[] result = _n1_TwoSum.TwoSum(nums, target);
            int[] expected = [0, 1];

            CollectionAssert.AreEqual(expected, result);
        }
    }
}