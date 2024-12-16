using LeetCode_Problems;

namespace Tests
{
    public class N17_PhoneLettersCombinations_Test
    {
        private readonly N17_PhoneLettersCombinations n17_PhoneLettersCombinations;

        public N17_PhoneLettersCombinations_Test()
        {
            n17_PhoneLettersCombinations = new();
        }

        [TestCaseSource(nameof(TestCases))]
        public void Test1(string target, IList<string> expected)
        {
            var actual = n17_PhoneLettersCombinations.LetterCombinations(target);
            Assert.That(actual, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    "23",
                    (IList<string>)["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]);

                yield return new TestCaseData(
                    "",
                    (IList<string>)[]);

                yield return new TestCaseData(
                    "2",
                    (IList<string>)["a", "b", "c"]);
            }
        }
    }
}
