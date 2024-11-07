using LeetCode_Problems;

namespace Tests
{
    public class N11_ContainerWithMostWater_Test
    {
        private readonly N11_ContainerWithMostWater _n11_ContainerWithMostWater;

        public N11_ContainerWithMostWater_Test()
        {
            _n11_ContainerWithMostWater = new N11_ContainerWithMostWater();
        }

        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new int[] { 1, 1 }, 1)]
        [TestCase(new int[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
        public void Test1(int[] height, int expected)
        {
            var actual = _n11_ContainerWithMostWater.MaxArea(height);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
