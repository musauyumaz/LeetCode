namespace LeetCode
{
    public sealed class Q00001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dictionary.ContainsKey(diff))
                    return new[] { dictionary[diff], i };
                dictionary[nums[i]] = i;
            }

            return null;
        }

        public void Test()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 2, 4 };
            int[] nums3 = { 3, 3 };
            Q00001_TwoSum twoSumSolution = new();

            Array.ForEach(twoSumSolution.TwoSum(nums, 9), x => Console.Write(x + ", "));
            Console.WriteLine();
            Array.ForEach(twoSumSolution.TwoSum(nums2, 6), x => Console.Write(x + ", "));
            Console.WriteLine();
            Array.ForEach(twoSumSolution.TwoSum(nums3, 6), x => Console.Write(x + ", "));
        }
    }
}
