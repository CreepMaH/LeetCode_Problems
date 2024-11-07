using LeetCode_Problems;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Tests
{
    public class N5_LongestPalindromicSubstring_Test
    {
        private readonly N5_LongestPalindromicSubstring _n5LongestPalindromicSubstring;

        public N5_LongestPalindromicSubstring_Test()
        {
            _n5LongestPalindromicSubstring = new();
        }

        [TestCase("babad", new string[] { "bab", "aba" })]
        [TestCase("cbbd", new string[] { "bb" })]
        [TestCase("a", new string[] { "a" })]
        public void Test1(string s, string[] expected)
        {
            string actual = _n5LongestPalindromicSubstring.LongestPalindrome(s);

            Assert.That(expected, Does.Contain(actual));
        }
    }
}
