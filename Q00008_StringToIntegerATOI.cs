namespace LeetCode
{
    public sealed class Q00008_StringToIntegerATOI
    {
        public int MyAtoi(string s)
        {
            ReadOnlySpan<char> spanChar = s.AsSpan().TrimStart();
            
            long result = 0;
            int sign = 1;
            int index = 0;
            int n = spanChar.Length;

            if (index < n && (spanChar[index] == '-' || spanChar[index] == '+'))
            {
                if (spanChar[index] == '-') sign = -1;
                index++;
            }

            while (index < n && spanChar[index] >= '0' && spanChar[index] <= '9')
            {
                int digit = spanChar[index] - '0';
                result = (result * 10) + digit;

                if (sign == 1 && result > int.MaxValue) return int.MaxValue;
                if (sign == -1 && -result < int.MinValue) return int.MinValue;

                index++;
            }

            return (int)(sign * result);
        }

        public static void Test()
        {
            Q00008_StringToIntegerATOI solution = new Q00008_StringToIntegerATOI();
            Console.WriteLine(solution.MyAtoi("42"));
            Console.WriteLine(solution.MyAtoi("-042"));
            Console.WriteLine(solution.MyAtoi("1337c0d3"));
            Console.WriteLine(solution.MyAtoi("0-1"));
            Console.WriteLine(solution.MyAtoi("words and 987"));
            Console.WriteLine(solution.MyAtoi("   -42"));
            Console.WriteLine(solution.MyAtoi("4193 with words"));
            Console.WriteLine(solution.MyAtoi("words and 987"));
            Console.WriteLine(solution.MyAtoi("-91283472332"));
        }
    }
}
