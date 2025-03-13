using LeetCode_Problems;
using LeetCode_Problems.Common;

namespace Tests
{
    [TestFixture]
    [Category("N20-29")]
    internal class N25_ReverseNodesInKGroup_Test
    {
        private readonly N25_ReverseNodesInKGroup _n25_ReverseNodesInKGroup;

        public N25_ReverseNodesInKGroup_Test()
        {
            _n25_ReverseNodesInKGroup = new N25_ReverseNodesInKGroup();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode head, int k, ListNode? expected)
        {
            List<int> expectedValues = [];
            while (expected?.next != null)
            {
                expectedValues.Add(expected.val);
                expected = expected.next;
            }

            var actual = _n25_ReverseNodesInKGroup.ReverseKGroup(head, k);

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
                    Common.LinkedListCreator.CreateHead([1, 2, 3, 4, 5]),
                    2,
                    Common.LinkedListCreator.CreateHead([2, 1, 4, 3, 5]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1, 2, 3, 4, 5]),
                    3,
                    Common.LinkedListCreator.CreateHead([3, 2, 1, 4, 5]));
            }
        }
    }
}
