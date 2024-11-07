using LeetCode_Problems;

namespace Tests
{
    internal class N4_MedianOfTwoSortedArrays_Test
    {
        private N4_MedianOfTwoSortedArrays _n4_MedianOfTwoSortedArrays;

        [SetUp]
        public void Setup()
        {
            _n4_MedianOfTwoSortedArrays = new N4_MedianOfTwoSortedArrays();
        }

        [Test]
        public void Test1()
        {
            int[] nums1 = [1, 3];
            int[] nums2 = [2];

            double actual = _n4_MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
            double expected = 2;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            int[] nums1 = [1, 2];
            int[] nums2 = [3, 4];

            double actual = _n4_MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
            double expected = 2.5;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
