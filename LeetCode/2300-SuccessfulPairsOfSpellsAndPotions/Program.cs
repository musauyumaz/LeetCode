using _2300_SuccessfulPairsOfSpellsAndPotions;

Solution solution = new();
int[] spells = {5,1,3};
int[] potions = {1,2,3,4,5};

foreach (var num in solution.SuccessfulPairs(spells,potions,7))
{
    Console.Write($"{num} ");
}