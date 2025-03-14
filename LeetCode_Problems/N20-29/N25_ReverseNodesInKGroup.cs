using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N25_ReverseNodesInKGroup
    {
        internal ListNode? ReverseKGroup(ListNode? head, int k)
        {
            if (head == null || k == 1)
            {
                return head;
            }

            // Check if there are at least k nodes remaining in the list
            int count = 0;
            ListNode? current = head;
            while (current != null && count < k)
            {
                current = current.next;
                count++;
            }

            if (count < k)
            {
                return head; // Not enough nodes to reverse
            }

            // Reverse the first k nodes in the current group
            ListNode? prev = null;
            ListNode? next = null;
            current = head;
            for (int i = 0; i < k; i++)
            {
                next = current.next;
                current.next = prev;

                prev = current;
                current = next;
            }

            // Recursively reverse the remaining part of the list
            head.next = ReverseKGroup(current, k);

            return prev; // 'prev' is now the new head of this group
        }
    }

}
