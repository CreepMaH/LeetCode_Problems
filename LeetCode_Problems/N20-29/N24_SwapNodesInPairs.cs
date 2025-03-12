using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N24_SwapNodesInPairs
    {
        internal ListNode? SwapPairs(ListNode? head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode next = head.next;
            head.next = SwapPairs(next.next);
            next.next = head;

            return next;
        }
    }

}
