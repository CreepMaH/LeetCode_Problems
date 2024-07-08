using LeetCode_Problems;

namespace Tests
{
    public class N2_AddTwoNumbers_Test
    {
        private N2_AddTwoNumbers _n2_AddTwoNumbers;

        [SetUp]
        public void Setup()
        {
            _n2_AddTwoNumbers = new N2_AddTwoNumbers();
        }

        [Test]
        public void OrdinaryTest()
        {
            int[] nodeArray1 = [2, 4, 3];
            N2_AddTwoNumbers.ListNode listNode1 = new(nodeArray1[0]);
            CreateListNodeFromArray(nodeArray1, listNode1, 1);

            int[] nodeArray2 = [5, 6, 4];
            N2_AddTwoNumbers.ListNode listNode2 = new(nodeArray2[0]);
            CreateListNodeFromArray(nodeArray2, listNode2, 1);


            N2_AddTwoNumbers.ListNode addNumbersNode = _n2_AddTwoNumbers.AddTwoNumbers(listNode1, listNode2);
            var result = CreateStringFromListNode(addNumbersNode);

            int[] nodeArrayExpected = [7, 0, 8];
            N2_AddTwoNumbers.ListNode expectedNode = new(nodeArrayExpected[0]);
            CreateListNodeFromArray(nodeArrayExpected, expectedNode, 1);
            var expected = CreateStringFromListNode(expectedNode);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void EmptyNodesTest()
        {
            int[] nodeArray1 = [0];
            N2_AddTwoNumbers.ListNode listNode1 = new(nodeArray1[0]);
            CreateListNodeFromArray(nodeArray1, listNode1, 1);

            int[] nodeArray2 = [0];
            N2_AddTwoNumbers.ListNode listNode2 = new(nodeArray2[0]);
            CreateListNodeFromArray(nodeArray2, listNode2, 1);


            N2_AddTwoNumbers.ListNode addNumbersNode = _n2_AddTwoNumbers.AddTwoNumbers(listNode1, listNode2);
            var result = CreateStringFromListNode(addNumbersNode);

            int[] nodeArrayExpected = [0];
            N2_AddTwoNumbers.ListNode expectedNode = new(nodeArrayExpected[0]);
            CreateListNodeFromArray(nodeArrayExpected, expectedNode, 1);
            var expected = CreateStringFromListNode(expectedNode);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OverflowTest()
        {
            int[] nodeArray1 = [9, 9, 9, 9, 9, 9, 9];
            N2_AddTwoNumbers.ListNode listNode1 = new(nodeArray1[0]);
            CreateListNodeFromArray(nodeArray1, listNode1, 1);

            int[] nodeArray2 = [9, 9, 9, 9];
            N2_AddTwoNumbers.ListNode listNode2 = new(nodeArray2[0]);
            CreateListNodeFromArray(nodeArray2, listNode2, 1);


            N2_AddTwoNumbers.ListNode addNumbersNode = _n2_AddTwoNumbers.AddTwoNumbers(listNode1, listNode2);
            var result = CreateStringFromListNode(addNumbersNode);

            int[] nodeArrayExpected = [8, 9, 9, 9, 0, 0, 0, 1];
            N2_AddTwoNumbers.ListNode expectedNode = new(nodeArrayExpected[0]);
            CreateListNodeFromArray(nodeArrayExpected, expectedNode, 1);
            var expected = CreateStringFromListNode(expectedNode);

            Assert.AreEqual(expected, result);
        }

        private void CreateListNodeFromArray(int[] nums, N2_AddTwoNumbers.ListNode listNode, int nodesCount)
        {
            if (nodesCount > nums.Length - 1)
            {
                return;
            }

            listNode.next = new(nums[nodesCount]);
            CreateListNodeFromArray(nums, listNode.next, nodesCount + 1);
        }

        private string CreateStringFromListNode(N2_AddTwoNumbers.ListNode listNode)
        {
            string result = string.Empty;
            while (listNode != null) 
            {
                result += listNode.val;
                listNode = listNode.next;
            }                        
            
            return result;
        }
    }
}