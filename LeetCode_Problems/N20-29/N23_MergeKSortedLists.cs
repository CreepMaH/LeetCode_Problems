using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N23_MergeKSortedLists
    {
        internal ListNode? MergeKLists(ListNode?[] lists)
        {
            int minNodeIndex = -1;
            int minVal = int.MaxValue;

            for (int i = 0; i < lists?.Length; i++)
            {
                if (lists[i]?.val <= minVal)
                {
                    minNodeIndex = i;
                    minVal = lists[i]!.val;
                }
            }

            if (minNodeIndex < 0)
            {
                return null;
            }

            ListNode minNode = lists![minNodeIndex]!;
            lists[minNodeIndex] = minNode.next;
            minNode.next = MergeKLists(lists);

            return minNode;
        }

        internal ListNode? MergeKLists_MinHeap(ListNode?[] lists)
        {
            PriorityQueue<ListNode, int> queue = new();
            foreach (var node in lists)
            {
                if (node != null)
                {
                    queue.Enqueue(node, node.val);
                }
            }

            ListNode? dummy = new();
            ListNode? tail = dummy;

            while (queue.Count > 0)
            {
                tail.next = queue.Dequeue();
                tail = tail.next;

                var next = tail.next;
                if (next != null)
                {
                    queue.Enqueue(next!, next!.val);
                }
            }

            return dummy.next;
        }
    }

}
