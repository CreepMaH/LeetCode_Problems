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
            List<ListNode> result = new()
            {
                new ListNode()
            };

            ListNode? addNode1 = l1;
            ListNode? addNode2 = l2;
            int transferDigit = 0;

            while (addNode1 != null || addNode2 != null)
            {
                int sum = (addNode1?.val ?? 0) + (addNode2?.val ?? 0) + transferDigit;

                var currentNode = result.Last();

                currentNode.val = sum % 10;

                addNode1 = addNode1?.next;
                addNode2 = addNode2?.next;

                if (addNode1 != null || addNode2 != null)
                {
                    currentNode.next = new ListNode();
                    result.Add(currentNode.next);

                    transferDigit = sum / 10;
                }
                else if (sum / 10 > 0)
                {
                    result.Last().next = new ListNode(transferDigit);
                    result.Add(result.Last().next);
                }
            }

            return result[0];
        }
    }
}
