using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                int right = left + 1;

                while (right < s.Length)
                {
                    string currentString = s[left..(right + 1)];
                    bool isPalindrome = CheckTheStringIsPalindrome(currentString);
                    if (isPalindrome)
                    {
                        bool isCurrentStringLonger = isPalindrome && longestPalindrome.Length < currentString.Length;

                        if (isCurrentStringLonger)
                        {
                            longestPalindrome = currentString;
                        }
                    }

                    right++;
                }
            }

            return longestPalindrome;
        }

        private bool CheckTheStringIsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

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
