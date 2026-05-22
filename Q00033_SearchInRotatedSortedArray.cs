namespace LeetCode
{
    public sealed class Q00033_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }

        public static void Test()
        {
            var solution = new Q00033_SearchInRotatedSortedArray();
            Console.WriteLine(solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
            Console.WriteLine(solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
            Console.WriteLine(solution.Search(new[] { 1 }, 0));
        }
    }
}
