using LeetCode_Problems;

namespace Tests
{
    public class N10_RegularExpression_Test
    {
        private readonly N10_RegularExpression _n10_RegularExpression;

        public N10_RegularExpression_Test()
        {
            _n10_RegularExpression = new N10_RegularExpression();
        }

        public void Test1(string s, string p, bool expected)
        {
            var actual = _n10_RegularExpression.IsMatch(s, p);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
