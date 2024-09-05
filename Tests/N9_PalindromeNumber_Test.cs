using LeetCode_Problems;

namespace Tests
{
    public class N9_PalindromeNumber_Test
    {
        private readonly N9_PalindromeNumber _n9_PalindromeNumber;

        public N9_PalindromeNumber_Test()
        {
            _n9_PalindromeNumber = new N9_PalindromeNumber();
        }

        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        public void Test1(int x, bool expected)
        {
            var actual = _n9_PalindromeNumber.IsPalindrome(x);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
