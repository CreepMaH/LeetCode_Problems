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
            List<char> list = [];

            while (right < s.Length)
            {
                list.Add(s[right]);
                if (hashSet.Add(s[right]))
                {
                    if (hashSet.Count > maxLength)
                    {
                        maxLength++;
                    }
                }
                else
                {
                    int duplicateIndex = list.FindIndex(c => c == s[right]);

                    while (duplicateIndex >= 0)
                    {
                        hashSet.Remove(list[0]);
                        list.RemoveAt(0);
                        duplicateIndex--;
                    }
                    
                    hashSet.Add(s[right]);
                    left++;
                }

                right++;
            }

            return maxLength;
        }
    }
}
