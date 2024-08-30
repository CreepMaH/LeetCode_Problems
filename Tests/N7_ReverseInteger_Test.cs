using LeetCode_Problems;

namespace Tests
{
    public class N7_ReverseInteger_Test
    {
        readonly N7_ReverseInteger _n7_ReverseInteger;

        public N7_ReverseInteger_Test()
        {
            _n7_ReverseInteger = new N7_ReverseInteger();
        }

        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        public void Test1(int x, int expected)
        {
            int actual = _n7_ReverseInteger.Reverse(x);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
