namespace LeetCode
{
    public sealed class Q00003_LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            string currentSubstring = string.Empty;
            int maxLength = 0;
            foreach (char c in s)
            {
                int index = currentSubstring.IndexOf(c);
                if (index != -1)
                {
                    currentSubstring = currentSubstring[(index + 1)..];
                }
                currentSubstring += c;
                maxLength = Math.Max(maxLength, currentSubstring.Length);
            }
            return maxLength;
        }

        public static void Test()
        {
            Q00003_LengthOfLongestSubstring solution = new();
            string input = "abcabcbb";
            int result = solution.LengthOfLongestSubstring(input);
            Console.WriteLine($"Input: {input}, Length of Longest Substring Without Repeating Characters: {result}");

            string input2 = "bbbbb";
            int result2 = solution.LengthOfLongestSubstring(input2);
            Console.WriteLine($"Input: {input2}, Length of Longest Substring Without Repeating Characters: {result2}");

            string input3 = "pwwkew";
            int result3 = solution.LengthOfLongestSubstring(input3);
            Console.WriteLine($"Input: {input3}, Length of Longest Substring Without Repeating Characters: {result3}");
        }
    }
}
