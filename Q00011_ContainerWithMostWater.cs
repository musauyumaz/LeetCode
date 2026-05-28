namespace LeetCode;

public class Q00011_ContainerWithMostWater
{
    public int MaxArea(int[] area)
    {
        ReadOnlySpan<int> spanArea = area.AsSpan();
        int maxArea = 0;
        int left = 0;
        int right = spanArea.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int currentHeight = Math.Min(spanArea[left], spanArea[right]);
            int currentArea = currentHeight * width;

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (spanArea[left] < spanArea[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    public static void Test()
    {
        var q = new Q00011_ContainerWithMostWater();
        Console.WriteLine(q.MaxArea(new []{1,8,6,2,5,4,8,3,7}));
        Console.WriteLine(q.MaxArea(new []{1,1}));
    }
}