using LeetCode_Problems;

namespace Tests
{
    public class N15_3Sum_Test
    {
        private readonly N15_3Sum n15_3Sum;

        public N15_3Sum_Test()
        {
            n15_3Sum = new N15_3Sum();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int[] nums, IList<IList<int>> expected)
        {
            var actual = n15_3Sum.ThreeSum(nums);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { -1, 0, 1, 2, -1, -4 },
                    new List<IList<int>>
                    {
                        new List<int> { -1, -1, 2 },
                        new List<int> { -1, 0, 1 }
                    });

                yield return new TestCaseData(
                    new int[] { 0, 1, 1 },
                    new List<IList<int>>());

                yield return new TestCaseData(
                    new int[] { 0, 0, 0 },
                    new List<IList<int>>
                    {
                        new List<int> { 0, 0, 0 }
                    });
            }
        }
    }
}
