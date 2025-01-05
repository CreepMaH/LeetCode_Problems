using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N21_MergeTwoSortedLists
    {
        internal ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            List<int> values = [];
            ListNode? current1 = list1,
                current2 = list2;

            while (true)
            {
                if (current1 == null && current2 == null)
                {
                    break;
                }

                if (current1 != null)
                {
                    values.Add(current1.val);
                    current1 = current1.next;
                }
                if (current2 != null)
                {
                    values.Add(current2.val);
                    current2 = current2.next;
                }
            }

            if (values.Count > 0)
            {
                values.Sort();
                ListNode head = new ListNode
                {
                    next = null,
                    val = values[0]
                };

                ListNode next = head;
                for (int i = 1; i < values.Count; i++)
                {
                    next.next = new ListNode
                    {
                        val = values[i],
                        next = null
                    };

                    next = next.next;
                }
                return head;
            }
            else
            {
                return null;
            }
        }
    }

}
