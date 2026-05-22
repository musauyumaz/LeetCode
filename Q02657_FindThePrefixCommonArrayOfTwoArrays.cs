namespace LeetCode
{
    public sealed class Q02657_FindThePrefixCommonArrayOfTwoArrays
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            Span<int> frekans = stackalloc int[51];
            int[] result = new int[A.Length];

            int commonCount = 0;
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] == B[i])
                {
                    commonCount++;
                }
                else
                {
                    frekans[A[i]]++;
                    if (frekans[A[i]] == 2)
                    {
                        commonCount++;
                    }

                    frekans[B[i]]++;

                    if (frekans[B[i]] == 2)
                    {
                        commonCount++;
                    }
                }
                


                result[i] = commonCount;

            }

            return result;
        }

        public static void Test()
        {
            var solution = new Q02657_FindThePrefixCommonArrayOfTwoArrays();
            Console.WriteLine(string.Join(", ", solution.FindThePrefixCommonArray(new[] { 2, 3, 1 }, new[] { 3, 1, 2 })));
            Console.WriteLine(string.Join(", ", solution.FindThePrefixCommonArray(new[] { 1, 3, 2, 4 }, new[] { 3, 1, 2, 4 })));
        }
    }
}
