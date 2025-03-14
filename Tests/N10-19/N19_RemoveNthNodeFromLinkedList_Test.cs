﻿using LeetCode_Problems;
using LeetCode_Problems.Common;

namespace Tests
{
    internal class N19_RemoveNthNodeFromLinkedList_Test
    {
        private readonly N19_RemoveNthNodeFromLinkedList _n19_RemoveNthNodeFromLinkedList;

        internal N19_RemoveNthNodeFromLinkedList_Test()
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

        internal static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1, 2, 3, 4, 5]),
                    2,
                    Common.LinkedListCreator.CreateHead([1, 2, 3, 5]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1]),
                    1,
                    Common.LinkedListCreator.CreateHead([]));

                yield return new TestCaseData(
                    Common.LinkedListCreator.CreateHead([1, 2]),
                    1,
                    Common.LinkedListCreator.CreateHead([1]));
            }
        }
    }
}
