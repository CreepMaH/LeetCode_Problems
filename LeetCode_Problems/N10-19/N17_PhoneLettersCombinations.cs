using System.Text;

namespace LeetCode_Problems
{
    public class N17_PhoneLettersCombinations
    {
        private readonly Dictionary<int, string[]> _keyMap = new()
        {
            { 2, ["a", "b", "c"] },
            { 3, ["d", "e", "f"] },
            { 4, ["g", "h", "i"] },
            { 5, ["j", "k", "l"] },
            { 6, ["m", "n", "o"] },
            { 7, ["p", "q", "r", "s"] },
            { 8, ["t", "u", "v"] },
            { 9, ["w", "x", "y", "z"] }
        };

        public IList<string> LetterCombinations(string digits)
        {
            List<string> combinations = [];

            foreach (char dig in digits)
            {
                List<string> newCombinations = [];
                var letters = _keyMap[Convert.ToInt32(dig.ToString())];

                foreach (string lett in letters)
                {
                    if (combinations.Count > 0)
                    {
                        foreach (string comb in combinations)
                        {
                            newCombinations.Add($"{comb}{lett}");
                        }
                    }
                    else
                    {
                        newCombinations.Add(lett);
                    }
                }

                combinations.Clear();
                combinations.AddRange(newCombinations);
            }

            combinations.Sort();
            return [.. combinations];
        }
    }
}
