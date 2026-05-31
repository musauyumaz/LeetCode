using System.Text;

namespace LeetCode;

public class Q00012_IntegerToRoman
{
    public string IntToRoman(int num)
    {
        ReadOnlySpan<string> thousands = new[]{ "" , "M","MM", "MMM"};
        ReadOnlySpan<string> hundreds = new[]{ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        ReadOnlySpan<string> tens = new[]{ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        ReadOnlySpan<string> ones = new[]{ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        StringBuilder sb = new();
        
        sb.Append(thousands[num / 1000]);
        num -= (num / 1000) * 1000;
        sb.Append(hundreds[num / 100]);
        num -= (num / 100) * 100;
        sb.Append(tens[num / 10]);
        num -= (num / 10) * 10;
        sb.Append(ones[num / 1]);
        num -= (num / 1) * 1;
        
        return sb.ToString();
    }
    
    public static void Test()
    {
        var q = new Q00012_IntegerToRoman();
        Console.WriteLine(q.IntToRoman(3749));
        Console.WriteLine(q.IntToRoman(58));
        Console.WriteLine(q.IntToRoman(1994));
    }
}