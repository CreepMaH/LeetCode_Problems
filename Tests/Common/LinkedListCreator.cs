using LeetCode_Problems.Common;

namespace Tests.Common
{
    internal static class LinkedListCreator
    {
        /// <summary>
        /// Creates linked list with values from integer array.
        /// </summary>
        /// <param name="nodesValues">The head of linked list.</param>
        /// <returns></returns>
        internal static ListNode? CreateHead(int[]? nodesValues)
        {
            ListNode head = new();
            if (nodesValues?.Length > 0)
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

        internal static ListNode?[] CreateArray(int[][] nodesValues)
        {
            List<ListNode?> listNodes = [];

            foreach (var node in nodesValues)
            {
                listNodes.Add(CreateHead(node));
            }

            return [.. listNodes];
        }
    }
}
