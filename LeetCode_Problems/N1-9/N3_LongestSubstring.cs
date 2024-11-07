namespace LeetCode_Problems
{
    public class N3_LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;

            int left = 0;
            int right = 0;

            HashSet<char> hashSet = [];

            while (right < s.Length)
            {
                if (!hashSet.Contains(s[right]))
                {
                    hashSet.Add(s[right]);
                    if (hashSet.Count > maxLength)
                    {
                        maxLength++;
                    }
                }
                else
                {
                    while (hashSet.Contains(s[right]))
                    {
                        hashSet.Remove(s[left]);
                        left++;
                    }
                    hashSet.Add(s[right]);
                }

                right++;
            }

            return maxLength;
        }
    }
}
