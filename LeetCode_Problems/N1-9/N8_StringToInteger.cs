using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class N8_StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            bool isNegative = s.StartsWith('-');
            if (isNegative || s.StartsWith('+'))
            {
                s = s[1..];
            }

            int maxAbsValue = int.MaxValue / 10;

            int result = 0;
            int digitPow = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int digitToAdd = (int)char.GetNumericValue(s[i]);

                    if (digitToAdd == 0 && result == 0)
                    {
                        continue;
                    }

                    if (result > maxAbsValue || result < -maxAbsValue)
                    {
                        result = isNegative ? int.MinValue : int.MaxValue;
                        break;
                    }
                    else if (Math.Abs(result) == maxAbsValue)
                    {
                        if (isNegative && digitToAdd >= 8)
                        {
                            result = int.MinValue;
                            break;
                        }
                        else if (!isNegative && digitToAdd >= 7)
                        {
                            result = int.MaxValue;
                            break;
                        }
                        else
                        {
                            result *= 10;
                            result += (isNegative ? (-1) : 1) * digitToAdd;
                            digitPow++;
                        }
                    }
                    else
                    {
                        result *= 10;
                        result += (isNegative ? (-1) : 1) * digitToAdd;
                        digitPow++;
                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
