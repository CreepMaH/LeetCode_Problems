using LeetCode_Problems.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace LeetCode_Problems
{
    internal class N22_GenerateParenthesis
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> combinations = [];
            GenerateCombinations(combinations, "", 0, 0, n);
            return combinations;
        }

        private void GenerateCombinations(List<string> combinations, string currentCombination, int leftCount, int rightCount, int n)
        {
            if (leftCount +  rightCount == n * 2)
            {
                combinations.Add(currentCombination);
                return;
            }

            if (leftCount < n)
            {
                GenerateCombinations(combinations, currentCombination + "(", leftCount + 1, rightCount, n);
            }

            if (rightCount < leftCount)
            {
                GenerateCombinations(combinations, currentCombination + ")", leftCount, rightCount + 1, n);
            }
        }
    }

}
