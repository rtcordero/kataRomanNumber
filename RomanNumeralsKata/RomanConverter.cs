namespace RomanNumeralsKata;

public class RomanConverter
{
    public string ToRoman(int number)
    {
        // lógica para convertir número a romano

        var result = "";

        while (number > 0)
        {
            if (number>= 10)
            {
                result += "X";
                number -= 10;
                continue;
            }
            if (number>= 9)
            {
                result += "IX";
                number -= 9;
                continue;
            }
            if (number>= 5)
            {
                result += "V";
                number -= 5;
                continue;
            }

            if (number >= 4)
            {
                result += "IV";
                number -= 4;
                continue;
            }

            result += "I";
            number -= 1;
        }


        return result;
    }
}