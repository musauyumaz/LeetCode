using System.Text;

namespace LeetCode
{
    public sealed class Q00006_ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            StringBuilder[] rows = new StringBuilder[numRows];

            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            int currentRow = 0;
            int direction = 1;

            

            foreach (char c in s)
            {
                rows[currentRow].Append(c);

                if (currentRow == 0)
                {
                    direction = 1;
                }
                else if (currentRow == numRows - 1)
                {
                    direction = -1;
                }

                currentRow += direction;
            }

            StringBuilder result = new StringBuilder();
            foreach (StringBuilder row in rows)
            {
                result.Append(row);
            }

            return result.ToString();
        }

        public static void Test()
        {
            string s1 = "PAYPALISHIRING";
            int numRows1 = 3;
            string s2 = "PAYPALISHIRING";
            int numRows2 = 4;
            Q00006_ZigzagConversion solution = new();
            Console.WriteLine(solution.Convert(s1, numRows1));
            Console.WriteLine(solution.Convert(s2, numRows2));
            Console.WriteLine(solution.Convert("AB",1));
        }
    }
}
