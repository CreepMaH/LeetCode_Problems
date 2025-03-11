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
    }

}
