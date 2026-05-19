namespace LeetCode
{
    public sealed class Q02540_MinimumCommonValue
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).DefaultIfEmpty(-1).Min();
     
        }

        public static void Test()
        {
            int[] nums1 = { 1, 2, 3 }, nums2 = { 2, 4 };
            int[] nums3 = { 1, 2, 3, 6 }, nums4 = { 2, 3, 4, 5 };
            Q02540_MinimumCommonValue solution = new();
            Console.WriteLine(solution.GetCommon(nums1, nums2));
            Console.WriteLine(solution.GetCommon(nums3, nums4));
        }
    }
}
