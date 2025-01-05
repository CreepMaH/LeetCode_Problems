using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N21_MergeTwoSortedLists
    {
        internal ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            ListNode? dummy = new(),
                tail = dummy,
                current1 = list1,
                current2 = list2;

            while (current1 != null && current2 != null)
            {
                if (current1.val < current2.val)
                {
                    tail.next = current1;
                    current1 = current1.next;
                }
                else
                {
                    tail.next = current2;
                    current2 = current2.next;
                }

                tail = tail.next;
            }

            tail.next = current1 ?? current2;

            return dummy.next;
        }
    }

}
