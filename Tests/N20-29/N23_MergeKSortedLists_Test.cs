using LeetCode_Problems;
using LeetCode_Problems.Common;

namespace Tests
{
    [TestFixture]
    [Category("N20-29")]
    internal class N23_MergeKSortedLists_Test
    {
        private readonly N23_MergeKSortedLists _n23_MergeKSortedLists;

        public N23_MergeKSortedLists_Test()
        {
            _n23_MergeKSortedLists = new N23_MergeKSortedLists();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode?[] lists, ListNode? expected)
        {
            List<int> expectedValues = [];
            while (expected?.next != null)
            {
                expectedValues.Add(expected.val);
                expected = expected.next;
            }

            var actual = _n23_MergeKSortedLists.MergeKLists(lists);

            List<int> actualValues = [];
            while (actual?.next != null)
            {
                actualValues.Add(actual.val);
                actual = actual.next;
            }

            Assert.That(expectedValues, Is.EquivalentTo(actualValues));
        }

        internal static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateArray([[1, 4, 5], [1, 3, 4], [2, 6]]),
                    Common.LinkedListCreator.CreateSingle([1, 1, 2, 3, 4, 4, 5, 6]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateArray([]),
                    Common.LinkedListCreator.CreateSingle([]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateArray([[]]),
                    Common.LinkedListCreator.CreateSingle([]));
            }
        }
    }
}
