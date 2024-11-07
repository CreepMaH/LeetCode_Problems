namespace LeetCode_Problems
{
    //Given a string s, return the longest palindromic substring in s
    public class N5_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string longestPalindrome = s[0..1];

            for (int left = 0; left < s.Length; left++)
            {
                int right = left + longestPalindrome.Length;

                while (right < s.Length)
                {
                    bool isPalindrome = CheckTheStringIsPalindrome(s, left, right);
                    if (isPalindrome)
                    {
                        bool isCurrentStringLonger = isPalindrome;

                        if (isCurrentStringLonger)
                        {
                            longestPalindrome = s[left..(right + 1)];
                        }
                    }

                    right++;
                }
            }

            return longestPalindrome;
        }

        private bool CheckTheStringIsPalindrome(string s, int left, int right)
        {
            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
