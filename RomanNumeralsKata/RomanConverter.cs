using System.Text;

namespace RomanNumeralsKata;

public class RomanConverter
{
    private static readonly (int Value, string Symbol)[] RomanMap =
    {
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
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
                    result.Append('M');
                    number -= 1000;
                    continue;
                case >= 900: //Sustracción
                    result.Append("CM");
                    number -= 900;
                    continue;
                case >= 500:
                    result.Append("D");
                    number -= 500;
                    continue;
                case >= 400: //Sustracción
                    result.Append("CD");
                    number -= 400;
                    continue;
                case >= 100:
                    result.Append("C");
                    number -= 100;
                    continue;
                case >= 90: //Sustracción
                    result.Append("XC");
                    number -= 90;
                    continue;
                case >= 50:
                    result.Append('L');
                    number -= 50;
                    continue;
                case >= 40: //Sustracción
                    result.Append("XL");
                    number -= 40;
                    continue;
                case >= 10:
                    result.Append('X');
                    number -= 10;
                    continue;
                case >= 9: //Sustracción
                    result.Append("IX");
                    number -= 9;
                    continue;
                case >= 5:
                    result.Append('V');
                    number -= 5;
                    continue;
                case >= 4: //Sustracción
                    result.Append("IV");
                    number -= 4;
                    continue;
                default:
                    result.Append('I');
                    number -= 1;
                    break;
            }
        }


        return result.ToString();
    }
}