using LeetCode_Problems;

namespace Tests
{
    public class N3_LongestSubstring_Test
    {
        N3_LongestSubstring _n3_LongestSubstring;

        [SetUp]
        public void Setup()
        {
            _n3_LongestSubstring = new N3_LongestSubstring();
        }

        [Test]
        public void AbcTest() 
        {
            string input = "abcabcbb";

            int actual = _n3_LongestSubstring.LengthOfLongestSubstring(input);
            int expected = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BbbTest()
        {
            string input = "bbbbb";

            int actual = _n3_LongestSubstring.LengthOfLongestSubstring(input);
            int expected = 1;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void PwkeTest()
        {
            string input = "pwwkew";

            int actual = _n3_LongestSubstring.LengthOfLongestSubstring(input);
            int expected = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AabTest()
        {
            string input = "aab";

            int actual = _n3_LongestSubstring.LengthOfLongestSubstring(input);
            int expected = 2;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void QrsTest()
        {
            string input = "qrsvbspk";

            int actual = _n3_LongestSubstring.LengthOfLongestSubstring(input);
            int expected = 5;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
