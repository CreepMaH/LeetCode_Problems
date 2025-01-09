using LeetCode_Problems;

namespace Tests
{
    internal class N22_GenerateParenthesis_Test
    {
        private readonly N22_GenerateParenthesis _n22_GenerateParenthesis;

        public N22_GenerateParenthesis_Test()
        {
            _n22_GenerateParenthesis = new N22_GenerateParenthesis();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(int n, IList<string> expected)
        {
            var actual = _n22_GenerateParenthesis.GenerateParenthesis(n);

            Assert.That(expected, Is.EquivalentTo(actual));
        }

        internal static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    3,
                    new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()"});

                yield return new TestCaseData(
                    1,
                    new List<string> { "()" });
            }
        }
    }
}
