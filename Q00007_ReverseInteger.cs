namespace LeetCode
{
    public sealed class Q00007_ReverseInteger
    {
        public int Reverse(int x)
        {
            char[]? s = null;
            if (x < 0)
            {
                x *= -1;
                s = x.ToString().ToCharArray();
                Array.Reverse(s);
                return (int.TryParse(new string(s), out int result) ? result : 0) * -1;
            }
            else
            {
                s = x.ToString().ToCharArray();
                Array.Reverse(s);
                return int.TryParse(new string(s), out int result) ? result : 0;
            }
        }

        public static void Test()
        {
            var solution = new Q00007_ReverseInteger();
            Console.WriteLine(solution.Reverse(123));
            Console.WriteLine(solution.Reverse(-123));
            Console.WriteLine(solution.Reverse(120));
            Console.WriteLine(solution.Reverse(0));
        }
    }
}
