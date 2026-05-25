namespace LeetCode
{
    public sealed class Q00010_RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            ReadOnlySpan<char> sSpan = s.AsSpan();
            ReadOnlySpan<char> pSpan = p.AsSpan();

            if (sSpan.Length == pSpan.Length && sSpan.SequenceEqual(pSpan))
                return true;

            return MatchHelper(sSpan, pSpan);
        }

        private bool MatchHelper(ReadOnlySpan<char> s, ReadOnlySpan<char> p)
        {
            if (p.IsEmpty) return s.IsEmpty;

            bool firstMatch = !s.IsEmpty && (p[0] == s[0] || p[0] == '.');

            if (p.Length >= 2 && p[1] == '*')
            {
                return MatchHelper(s, p.Slice(2)) || (firstMatch && MatchHelper(s.Slice(1), p));
            }
            else
            {
                return firstMatch && MatchHelper(s.Slice(1), p.Slice(1));
            }
        }

        public static void Test()
        {
            var solution = new Q00010_RegularExpressionMatching();
            Console.WriteLine(solution.IsMatch("aa", "a")); // false
            Console.WriteLine(solution.IsMatch("aa", "a*")); // true
            Console.WriteLine(solution.IsMatch("ab", ".*")); // true
            Console.WriteLine(solution.IsMatch("aab", "c*a*b")); // true
            Console.WriteLine(solution.IsMatch("mississippi", "mis*is*p*.")); // false
        }
    }
}
