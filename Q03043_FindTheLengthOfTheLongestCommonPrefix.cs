namespace LeetCode
{
    public sealed class Q03043_FindTheLengthOfTheLongestCommonPrefix
    {
        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            HashSet<int> prefixler = new HashSet<int>();

            foreach (int num in arr1)
            {
                int temporary = num;
                while (temporary > 0)
                {
                    prefixler.Add(temporary);
                    temporary /= 10;
                }
            }

            int maxLength = 0;

            foreach (int num in arr2)
            {
                int temporary = num;
                while (temporary > 0)
                {
                    if (prefixler.Contains(temporary))
                    {
                        int length = temporary.ToString().Length;

                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                        break;
                    }
                    temporary /= 10;
                }
            }

            return maxLength;
        }

        public static void Test()
        {
            Q03043_FindTheLengthOfTheLongestCommonPrefix solution = new();
            Console.WriteLine(solution.LongestCommonPrefix(new int[] { 123, 456, 789 }, new int[] { 12, 45, 78 }));
            Console.WriteLine(solution.LongestCommonPrefix(new int[] { 1,10,100 }, new int[] { 1000 }));
            Console.WriteLine(solution.LongestCommonPrefix(new int[] { 1,2,3 }, new int[] { 4,4,4 }));
        }
    }
}
