namespace _1518_WaterBottles;

public sealed class WaterBottle
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        return (numBottles * numExchange - 1) / (numExchange - 1);
    }
}