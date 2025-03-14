namespace LeetCode_Problems.N20_29
{
    internal class N28_FindTheIndexOfFirstOccurence
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                int coincendenceLength = 0;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j >= haystack.Length)
                    {
                        return -1;
                    }
                    if (haystack[i + j] == needle[j])
                    {
                        coincendenceLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (coincendenceLength == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
