namespace _2300_2300_SuccessfulPairsOfSpellsAndPotions;

public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        List<int> result = new();
        int num = 0;
        int i = 0;
        Array.Sort(spells);
        if ((potions[potions.Length / 2 ] * spells[i] )< success)
        {
            i = (potions.Length / 2) + 1;
        }

        for (int j = 0; j < spells.Length; j++)
        {
            for (; i < potions.Length; i++)
            {
                if ((potions[i] * spells[i]) >= success)
                {
                    num++;
                }
            }

            result.Add(num);
            num = 0;
        }
        return result.ToArray();
    }
}