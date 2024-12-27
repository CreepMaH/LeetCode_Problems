namespace LeetCode_Problems
{
    public class N20_ValidParentheses
    {
        Dictionary<char, char> _parenthesesPairs = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        public bool IsValid(string s)
        {
            Stack<char> parentheses = new();

            foreach (char currentChar in s)
            {
                if (_parenthesesPairs.ContainsKey(currentChar))
                {
                    parentheses.Push(currentChar);
                }
                else
                {
                    bool popSuccess = parentheses.TryPop(out char popChar);
                    if (!popSuccess || _parenthesesPairs[popChar] != currentChar)
                    {
                        return false;
                    }
                }
            }

            return parentheses.Count == 0;
        }
    }
}
