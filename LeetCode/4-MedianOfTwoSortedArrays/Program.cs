using _4_MedianOfTwoSortedArrays;

Solution solution = new();
int[] nums1 = { 1, 3 };
int[] nums2 = { 2 };
Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2));

int[] nums3 = { 1, 2 };
int[] nums4 = { 3,4 };
Console.WriteLine(solution.FindMedianSortedArrays(nums3, nums4));