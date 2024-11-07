using LeetCode_Problems;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Tests
{
    public class N6_ZigzagConversion_Test
    {
        private N6_ZigzagConversion _zigzagConversion;

        public N6_ZigzagConversion_Test()
        {
            _zigzagConversion = new N6_ZigzagConversion();
        }

        [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [TestCase("A", 1, "A")]
        public void TestConvert(string s, int numRows, string expected)
        {
            var actual = _zigzagConversion.Convert(s, numRows);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
