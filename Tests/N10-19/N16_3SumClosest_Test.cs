using LeetCode_Problems;

namespace Tests
{
    public class N16_3SumClosest_Test
    {
        private readonly N16_3SumClosest n16_3SumClosest;

        public N16_3SumClosest_Test()
        {
            n16_3SumClosest = new N16_3SumClosest();
        }

        [TestCase(new int[] {-1, 2, 1, -4}, 1, 2)]
        [TestCase(new int[] { 0, 0, 0 }, 1, 0)]
        [TestCase(new int[] { 4, 0, 5, -5, 3, 3, 0, -4, -5 }, -2, -2)]
        public void Test1(int[] nums, int target, int expected)
        {
            var actual = n16_3SumClosest.ThreeSumClosest(nums, target);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
