using LeetCode_Problems;

namespace Tests
{
    public class N13_RomanToInteger_Test
    {
        private readonly N13_RomanToInteger n13_RomanToInteger;

        public N13_RomanToInteger_Test()
        {
            n13_RomanToInteger = new N13_RomanToInteger();
        }

        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void Test1(string s, int expected)
        {
            var actual = n13_RomanToInteger.RomanToInt(s);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
