namespace _2300_SuccessfulPairsOfSpellsAndPotions;

public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);

        List<int> result = new List<int>();

        foreach (int spell in spells)
        {
            int low = 0;
            int high = potions.Length - 1;
            int firstSuccessfulPotionIndex = potions.Length; 

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                long product = (long)potions[mid] * spell; 
                if (product >= success)
                {
                    firstSuccessfulPotionIndex = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            result.Add(potions.Length - firstSuccessfulPotionIndex);
        }
        return result.ToArray();
    }
}