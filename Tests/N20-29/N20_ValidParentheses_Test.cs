using LeetCode_Problems;

namespace Tests
{
    public class N20_ValidParentheses_Test
    {
        private readonly N20_ValidParentheses _n20_ValidParentheses;

        public N20_ValidParentheses_Test()
        {
            _n20_ValidParentheses = new N20_ValidParentheses();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(string s, bool expected)
        {
            var actual = _n20_ValidParentheses.IsValid(s);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData("()", true);
                yield return new TestCaseData("()[]{}", true);
                yield return new TestCaseData("(]", false);
                yield return new TestCaseData("([])", true);
            }
        }
    }
}
