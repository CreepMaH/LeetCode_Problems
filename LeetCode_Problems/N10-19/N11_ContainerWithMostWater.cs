namespace LeetCode_Problems
{
    public class N11_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int leftIndex = 0;
            int rightIndex = height.Length - 1;

            int maxSquare = 0;

            while (leftIndex <= rightIndex)
            {
                int currentSquare = (rightIndex - leftIndex) * Math.Min(height[leftIndex], height[rightIndex]);
                if (currentSquare > maxSquare)
                {
                    maxSquare = currentSquare;
                }
                if (height[leftIndex] < height[rightIndex])
                {
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
            }

            return maxSquare;
        }
    }
}
