namespace LeetCode
{
    public sealed class Q00009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int original = x;
            long reversed = 0;

            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }

            return original == reversed;
        }

        public static void Test()
        {
            Q00009_PalindromeNumber solution = new Q00009_PalindromeNumber();
            Console.WriteLine(solution.IsPalindrome(121));
            Console.WriteLine(solution.IsPalindrome(-121));
            Console.WriteLine(solution.IsPalindrome(10));
            Console.WriteLine(solution.IsPalindrome(-101));
        }
    }
}
