using System.Text;

namespace LeetCode_Problems
{
    public class N12_IntegerToRoman
    {
        Dictionary<int, string> _alphabet = new()
        {
            { 1, "I" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" }
        };

        public string IntToRoman(int num)
        {
            StringBuilder stringBuilder = new();

            int calcBase = 1000;
            while (calcBase > 0)
            {
                AppendRomanString(num, calcBase, stringBuilder);
                num -= (num / calcBase) * calcBase;
                calcBase /= 10;
            }

            return stringBuilder.ToString();
        }

        private void AppendRomanString(int num, int calcBase, StringBuilder stringBuilder)
        {
            int digitsCount = num / calcBase;
            if (digitsCount > 0)
            {
                if (digitsCount == 4 || digitsCount == 9)
                {
                    stringBuilder.Append($"{_alphabet[calcBase]}{_alphabet[calcBase * ++digitsCount]}");
                }
                else
                {
                    if (digitsCount >= 5)
                    {
                        stringBuilder.Append(_alphabet[calcBase * 5]);
                        digitsCount -= 5;
                    }

                    for (int i = 0; i < digitsCount; i++)
                    {
                        stringBuilder.Append(_alphabet[calcBase]);
                    }
                }
            }
        }
    }
}
