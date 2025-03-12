using LeetCode_Problems;
using LeetCode_Problems.Common;

namespace Tests
{
    [TestFixture]
    [Category("N20-29")]
    internal class N24_SwapNodesInPairs_Test
    {
        private readonly N24_SwapNodesInPairs _n24_SwapNodesInPairs;

        public N24_SwapNodesInPairs_Test()
        {
            _n24_SwapNodesInPairs = new N24_SwapNodesInPairs();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode? head, ListNode? expected)
        {
            List<int> expectedValues = [];
            while (expected?.next != null)
            {
                expectedValues.Add(expected.val);
                expected = expected.next;
            }

            var actual = _n24_SwapNodesInPairs.SwapPairs(head);

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
                    Common.LinkedListCreator.CreateHead([1, 2, 3, 4]),
                    Common.LinkedListCreator.CreateHead([2, 1, 4, 3]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([]),
                    Common.LinkedListCreator.CreateHead([]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1]),
                    Common.LinkedListCreator.CreateHead([1]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1, 2, 3]),
                    Common.LinkedListCreator.CreateHead([2, 1, 3]));
            }
        }
    }
}
