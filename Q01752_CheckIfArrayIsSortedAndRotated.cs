namespace LeetCode
{
    public sealed class Q01752_CheckIfArrayIsSortedAndRotated
    {
        public bool Check(int[] nums)
        {
            ReadOnlySpan<int> numsSpan= nums.AsSpan();
            int count = 0;
            for (int i = 0; i < numsSpan.Length; i++)
            {
                if (numsSpan[i] > numsSpan[(i + 1) % numsSpan.Length])
                {
                    count++;
                }
            }
            return count <= 1;
        }

        public static void Test()
        {
            var solution = new Q01752_CheckIfArrayIsSortedAndRotated();
            Console.WriteLine(solution.Check(new[] { 3, 4, 5, 1, 2 })); 
            Console.WriteLine(solution.Check(new[] { 2, 1, 3, 4 }));
            Console.WriteLine(solution.Check(new[] { 1, 2, 3 })); 
        }
    }
}
