using System.Text;

namespace RomanNumeralsKata;

public class RomanConverter
{
    private static readonly Dictionary<int, string> RomanMap = new()
    {
        {1000, "M"},
        {900,  "CM"},
        {500,  "D"},
        {400,  "CD"},
        {100,  "C"},
        {90,   "XC"},
        {50,   "L"},
        {40,   "XL"},
        {10,   "X"},
        {9,    "IX"},
        {5,    "V"},
        {4,    "IV"},
        {1,    "I"}
    };

    public string ToRoman(int number)
    {
        // lógica para convertir número a romano

        var result = new StringBuilder();

        while (number > 0)
        {
            foreach (var romanMap in RomanMap)
            {
                if (number >= romanMap.Key)
                {
                    result.Append(romanMap.Value);
                    number -= romanMap.Key;
                    break;
                }
            }
        }


        return result.ToString();
    }
}