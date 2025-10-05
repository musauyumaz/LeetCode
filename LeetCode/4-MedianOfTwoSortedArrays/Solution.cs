namespace _4_MedianOfTwoSortedArrays
{
    public sealed class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArrays = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, 0, mergedArrays, 0, nums1.Length);
            Array.Copy(nums2, 0, mergedArrays, nums1.Length, nums2.Length);

            Array.Sort(mergedArrays);
            if (mergedArrays.Length % 2 == 0)
            {
               return (mergedArrays[(mergedArrays.Length / 2)] + mergedArrays[(mergedArrays.Length / 2) - 1]) / 2.0;
            }
            else
            {
                return mergedArrays[mergedArrays.Length / 2];
            }

        }
    }
}
