using LeetCode_Problems;

namespace Tests
{
    public class N12_IntegerToRoman_Test
    {
        private readonly N12_IntegerToRoman _n12_IntegerToRoman;

        public N12_IntegerToRoman_Test()
        {
            _n12_IntegerToRoman = new N12_IntegerToRoman();
        }

        [TestCase(3749, "MMMDCCXLIX")]
        [TestCase(58, "LVIII")]
        [TestCase(3999, "MMMCMXCIX")]
        public void Test1(int num, string expected)
        {
            var actual = _n12_IntegerToRoman.IntToRoman(num);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
