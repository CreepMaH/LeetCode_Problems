using LeetCode_Problems;
using LeetCode_Problems.Common;

namespace Tests
{
    [TestFixture]
    [Category("N20-29")]
    internal class N21_MergeTwoSortedLists_Test
    {
        private readonly N21_MergeTwoSortedLists _n21_MergeTwoSortedLists;

        public N21_MergeTwoSortedLists_Test()
        {
            _n21_MergeTwoSortedLists = new N21_MergeTwoSortedLists();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode? list1, ListNode? list2, ListNode? expected)
        {
            List<int> expectedValues = [];
            while (expected?.next != null)
            {
                expectedValues.Add(expected.val);
                expected = expected.next;
            }

            var actual = _n21_MergeTwoSortedLists.MergeTwoLists(list1, list2);

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
                    Common.LinkedListCreator.CreateLinkedList([1, 2, 4]),
                    Common.LinkedListCreator.CreateLinkedList([1, 3, 4]),
                    Common.LinkedListCreator.CreateLinkedList([1, 1, 2, 3, 4, 4]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateLinkedList([]),
                    Common.LinkedListCreator.CreateLinkedList([]),
                    Common.LinkedListCreator.CreateLinkedList([]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateLinkedList([]),
                    Common.LinkedListCreator.CreateLinkedList([0]),
                    Common.LinkedListCreator.CreateLinkedList([0]));
            }
        }
    }
}
