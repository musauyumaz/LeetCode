namespace _3_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
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
    }
}
