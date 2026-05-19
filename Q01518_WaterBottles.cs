namespace LeetCode
{
    public sealed class Q01518_WaterBottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            return (numBottles * numExchange - 1) / (numExchange - 1);
        }

        public static void Test()
        {
            Q01518_WaterBottles solution = new();
            Console.WriteLine(solution.NumWaterBottles(9, 3));
            Console.WriteLine(solution.NumWaterBottles(15, 4));
            Console.WriteLine(solution.NumWaterBottles(5, 5));
        }
    }
}
