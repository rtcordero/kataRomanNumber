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
            switch (number)
            {
                case >= 1000:
                    result.Append(RomanMap[1000]);
                    number -= 1000;
                    continue;
                case >= 900: //Sustracción
                    result.Append(RomanMap[900]);
                    number -= 900;
                    continue;
                case >= 500:
                    result.Append(RomanMap[500]);
                    number -= 500;
                    continue;
                case >= 400: //Sustracción
                    result.Append(RomanMap[400]);
                    number -= 400;
                    continue;
                case >= 100:
                    result.Append(RomanMap[100]);
                    number -= 100;
                    continue;
                case >= 90: //Sustracción
                    result.Append(RomanMap[90]);
                    number -= 90;
                    continue;
                case >= 50:
                    result.Append(RomanMap[50]);
                    number -= 50;
                    continue;
                case >= 40: //Sustracción
                    result.Append(RomanMap[40]);
                    number -= 40;
                    continue;
                case >= 10:
                    result.Append(RomanMap[10]);
                    number -= 10;
                    continue;
                case >= 9: //Sustracción
                    result.Append(RomanMap[9]);
                    number -= 9;
                    continue;
                case >= 5:
                    result.Append(RomanMap[5]);
                    number -= 5;
                    continue;
                case >= 4: //Sustracción
                    result.Append(RomanMap[4]);
                    number -= 4;
                    continue;
                default:
                    result.Append(RomanMap[1]);
                    number -= 1;
                    break;
            }
        }


        return result.ToString();
    }
}