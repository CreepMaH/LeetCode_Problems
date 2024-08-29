using System.Text;

namespace LeetCode_Problems
{
    public class N6_ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            Dictionary<int, List<char>> layers = [];
            int currentIndex = 0;
            while (currentIndex < s.Length)
            {
                for (int i = 0; i < numRows && currentIndex < s.Length; i++)
                {
                    //Почему-то эта проверка быстрее, чем инициализация Dictionary в цикле
                    if (!layers.ContainsKey(i))
                    {
                        layers[i] = [];
                    }
                    layers[i].Add(s[currentIndex]);
                    currentIndex++;
                }
                for (int j = numRows - 2; j > 0 && currentIndex < s.Length; j--)
                {
                    layers[j].Add(s[currentIndex]);
                    currentIndex++;
                }
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < layers.Count; i++)
            {
                foreach (char c in layers[i])
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
