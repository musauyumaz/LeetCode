using _1_TwoSum;

int[] nums = { 2, 7, 11, 15 };
int[] nums2 = { 3, 2, 4 };
int[] nums3 = { 3, 3 };
TwoSumSolution twoSumSolution = new();

Array.ForEach(twoSumSolution.TwoSum(nums, 9), x =>Console.Write(x + ", "));
Console.WriteLine();
Array.ForEach(twoSumSolution.TwoSum(nums2, 6), x =>Console.Write(x + ", "));
Console.WriteLine();
Array.ForEach(twoSumSolution.TwoSum(nums3, 6), x =>Console.Write(x + ", "));
