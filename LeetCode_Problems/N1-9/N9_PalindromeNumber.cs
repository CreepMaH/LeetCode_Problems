namespace LeetCode_Problems
{
    public class N9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            List<int> digits = [];
            while (true)
            {
                digits.Add(x % 10);
                if (x >= 10)
                {
                    x /= 10;
                }
                else
                {
                    break;
                }
            }

            int i = 0;
            int j = digits.Count - 1;
            while (i <= j)
            {
                if (digits[i] != digits[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
