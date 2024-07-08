namespace LeetCode_Problems
{
    public class N2_AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultNode = new();
            ListNode currentNode = resultNode;

            ListNode? addNode1 = l1;
            ListNode? addNode2 = l2;
            int transferDigit = 0;

            bool addNextNode = true;

            while (addNextNode)
            {
                int sum = (addNode1?.val ?? 0) + (addNode2?.val ?? 0) + transferDigit;

                currentNode.val = sum % 10;
                transferDigit = sum / 10;

                addNode1 = addNode1?.next;
                addNode2 = addNode2?.next;

                addNextNode = addNode1 != null || addNode2 != null || transferDigit != 0;
                if (addNextNode)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }

            return resultNode;
        }
    }
}
