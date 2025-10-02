namespace _1_TwoSum;

public sealed class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (dictionary.ContainsKey(diff))
                return new []{dictionary[diff], i};
            dictionary[nums[i]] = i;
        }

        return null;
    }
}