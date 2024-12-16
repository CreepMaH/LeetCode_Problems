using System.Text;

namespace LeetCode_Problems
{
    public class N17_PhoneLettersCombinations
    {
        private List<string> _combinations = [];
        private readonly Dictionary<char, string[]> _keyMap = new()
        {
            { '2', ["a", "b", "c"] },
            { '3', ["d", "e", "f"] },
            { '4', ["g", "h", "i"] },
            { '5', ["j", "k", "l"] },
            { '6', ["m", "n", "o"] },
            { '7', ["p", "q", "r", "s"] },
            { '8', ["t", "u", "v"] },
            { '9', ["w", "x", "y", "z"] }
        };

        public IList<string> LetterCombinations(string digits)
        {
            _combinations = [];
            if (!string.IsNullOrEmpty(digits))
            {
                BacktrackDigit("", digits);
            }
            
            return _combinations;
        }

        private void BacktrackDigit(string combination, string digitsRest)
        {
            if (string.IsNullOrEmpty(digitsRest))
            {
                _combinations.Add(combination);
            }
            else
            {
                foreach (string letter in _keyMap[digitsRest[0]])
                {
                    BacktrackDigit(combination + letter, digitsRest.Remove(0, 1));
                }
            }
        }
    }
}
