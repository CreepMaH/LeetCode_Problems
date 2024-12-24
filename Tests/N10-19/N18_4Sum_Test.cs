using LeetCode_Problems;

namespace Tests
{
    public class N18_4Sum_Test
    {
        private readonly N18_4Sum n15_3Sum;

        public N18_4Sum_Test()
        {
            n15_3Sum = new N18_4Sum();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, int target, IList<IList<int>> expected)
        {
            var actual = n15_3Sum.FourSum(nums, target);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 1, 0, -1, 0, -2, 2 },
                    0,
                    new List<IList<int>>
                    {
                        new List<int> { -2, -1, 1, 2 },
                        new List<int> { -2, 0, 0, 2 },
                        new List<int> { -1, 0, 0, 1 }
                    });

                yield return new TestCaseData(
                    new int[] { 2, 2, 2, 2, 2 },
                    8,
                    new List<IList<int>>()
                    {
                        new List<int> { 2, 2 ,2, 2, 2 }
                    });
            }
        }
    }
}
