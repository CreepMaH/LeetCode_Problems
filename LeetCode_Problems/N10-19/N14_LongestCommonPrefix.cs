using System.Text;

namespace LeetCode_Problems
{
    public class N14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int minLength = strs.Min(str => str.Length);

            StringBuilder builder = new ();

            for (int i = 0; i < minLength; i++)
            {
                char currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != currentChar)
                    {
                        return builder.ToString();
                    }
                }

                builder.Append(currentChar);
            }

            return builder.ToString();
        }
    }
}
