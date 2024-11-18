namespace LeetCode_Problems
{
    public class N13_RomanToInteger
    {
        private readonly Dictionary<char, int> _alphabet = new()
        {
            { 'I', 1 },
            { 'V' , 5 },
            { 'X' , 10 },
            { 'L', 50 },
            { 'C' , 100 },
            { 'D', 500 },
            { 'M' , 1000 }
        };

        public int RomanToInt(string s)
        {
            int num = _alphabet[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                int previous = _alphabet[s[i - 1]];
                int current = _alphabet[s[i]];

                num += current;

                if (previous < current)
                {
                    num -= previous * 2;
                }
            }

            return num;
        }
    }
}
