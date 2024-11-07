using System.Text;

namespace LeetCode_Problems
{
    public class N7_ReverseInteger
    {
        public int Reverse(int x)
        {
            bool hasMinusSign = x < 0;
            string xStr = x.ToString().Replace("-", null);
            StringBuilder stringBuilder = new();
            for (int i = xStr.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(xStr[i]);
            }
            if (hasMinusSign)
            {
                stringBuilder.Insert(0, "-");
            }

            if (int.TryParse(stringBuilder.ToString(), out int xReversed))
            {
                return xReversed;
            }
            else
            {
                return 0;
            }
        }
    }
}
