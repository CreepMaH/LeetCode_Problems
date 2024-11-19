using LeetCode_Problems;

namespace Tests
{
    public class N14_LongestCommonPrefix_Test
    {
        private readonly N14_LongestCommonPrefix n14_LongestCommonPrefix;

        public N14_LongestCommonPrefix_Test()
        {
            n14_LongestCommonPrefix = new N14_LongestCommonPrefix();
        }

        [TestCase(new string[] { "flower", "flow", "flight" }, "fl")]
        [TestCase(new string[] {"dog", "racecar", "car"}, "")]
        [TestCase(new string[] { "", "b" }, "")]
        public void Test1(string[] strs, string expected)
        {
            var actual = n14_LongestCommonPrefix.LongestCommonPrefix(strs);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
