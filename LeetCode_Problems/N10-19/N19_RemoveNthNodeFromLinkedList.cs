using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N19_RemoveNthNodeFromLinkedList
    {
        internal ListNode? RemoveNthFromEnd(ListNode? head, int n)
        {
            Queue<ListNode?> queue = new();
            queue.Enqueue(head);

            ListNode? next = head?.next;
            while (next != null)
            {
                queue.Enqueue(next);

                if (queue.Count > n + 1)
                {
                    queue.Dequeue();
                }

                next = next.next;
            }

            ListNode? nodeToChange = queue.Dequeue();
            if (queue.Count == n)
            {
                nodeToChange!.next = queue.Dequeue()?.next;
            }
            else if (queue.Count > 0)
            {
                head = queue.Dequeue();
            }
            else
            {
                head = null;
            }

            return head;
        }
    }

    

}
