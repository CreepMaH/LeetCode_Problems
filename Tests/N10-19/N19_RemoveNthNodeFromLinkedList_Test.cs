using LeetCode_Problems;

namespace Tests
{
    public class N19_RemoveNthNodeFromLinkedList_Test
    {
        private readonly N19_RemoveNthNodeFromLinkedList _n19_RemoveNthNodeFromLinkedList;

        public N19_RemoveNthNodeFromLinkedList_Test()
        {
            _n19_RemoveNthNodeFromLinkedList = new N19_RemoveNthNodeFromLinkedList();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(ListNode? head, int n, ListNode? expected)
        {
            List<int> expectedValues = [];
            while (expected?.next != null)
            {
                expectedValues.Add(expected.val);
                expected = expected.next;
            }

            var actual = _n19_RemoveNthNodeFromLinkedList.RemoveNthFromEnd(head, n);
            List<int> actualValues = [];
            while (actual?.next != null)
            {
                actualValues.Add(actual.val);
                actual = actual.next;
            }

            Assert.That(expectedValues, Is.EquivalentTo(actualValues));
        }

        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    CreateLinkedList([1, 2, 3, 4, 5]),
                    2,
                    CreateLinkedList([1, 2, 3, 5]));

                yield return new TestCaseData(
                    CreateLinkedList([1]),
                    1,
                    CreateLinkedList([]));

                yield return new TestCaseData(
                    CreateLinkedList([1, 2]),
                    1,
                    CreateLinkedList([1]));
            }
        }

        private static ListNode CreateLinkedList(int[] nodesValues)
        {
            ListNode head = new ();
            if (nodesValues.Length > 0)
            {
                head.val = nodesValues[0];
            }
            else
            {
                return null;
            }

            ListNode current = head;

            for (int i = 1; i < nodesValues.Length; i++)
            {
                current.next = new ListNode(nodesValues[i]);
                current = current.next;
            }

            return head;
        }
    }
}
