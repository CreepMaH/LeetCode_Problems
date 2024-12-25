namespace LeetCode_Problems
{
    public class N19_RemoveNthNodeFromLinkedList
    {
        public ListNode? RemoveNthFromEnd(ListNode? head, int n)
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
                nodeToChange.next = queue.Dequeue()?.next;
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

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
