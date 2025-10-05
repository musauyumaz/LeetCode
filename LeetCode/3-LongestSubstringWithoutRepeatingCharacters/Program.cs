
using _3_LongestSubstringWithoutRepeatingCharacters;

Solution solution = new Solution();
string input = "abcabcbb";
int result = solution.LengthOfLongestSubstring(input);
Console.WriteLine($"Input: {input}, Length of Longest Substring Without Repeating Characters: {result}");

string input2 = "bbbbb";
int result2 = solution.LengthOfLongestSubstring(input2);
Console.WriteLine($"Input: {input2}, Length of Longest Substring Without Repeating Characters: {result2}");

string input3 = "pwwkew";
int result3 = solution.LengthOfLongestSubstring(input3);
Console.WriteLine($"Input: {input3}, Length of Longest Substring Without Repeating Characters: {result3}");