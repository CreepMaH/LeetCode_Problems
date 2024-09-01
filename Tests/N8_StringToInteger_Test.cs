using LeetCode_Problems;

namespace Tests
{
    public class N8_StringToInteger_Test
    {
        private readonly N8_StringToInteger _n8_StringToInteger;

        public N8_StringToInteger_Test()
        {
            _n8_StringToInteger = new();
        }

        [TestCase("42", 42)]
        [TestCase("-042", -42)]
        [TestCase("1337c0d3", 1337)]
        [TestCase("0-1", 0)]
        [TestCase("words and 987", 0)]
        [TestCase("-91283472332", -2147483648)]
        [TestCase("2147483646", 2147483646)]
        [TestCase("-2147483649", -2147483648)]
        public void Test1(string s, int expected)
        {
            var actual = _n8_StringToInteger.MyAtoi(s);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
