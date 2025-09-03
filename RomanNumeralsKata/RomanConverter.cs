namespace RomanNumeralsKata;

public class RomanConverter
{
    public string ToRoman(int number)
    {
        // lógica para convertir número a romano

        var result = "";

        while (number > 0)
        {
            switch (number)
            {
                case >= 1000:
                    result += "M";
                    number -= 1000;
                    continue;
                case >= 500:
                    result += "D";
                    number -= 500;
                    continue;
                case >= 100:
                    result += "C";
                    number -= 100;
                    continue;
                case >= 90: //Sustracción
                    result += "XC";
                    number -= 90;
                    continue;
                case >= 50:
                    result += "L";
                    number -= 50;
                    continue;
                case >= 40: //Sustracción
                    result += "XL";
                    number -= 40;
                    continue;
                case >= 10:
                    result += "X";
                    number -= 10;
                    continue;
                case >= 9: //Sustracción
                    result += "IX";
                    number -= 9;
                    continue;
                case >= 5:
                    result += "V";
                    number -= 5;
                    continue;
                case >= 4: //Sustracción
                    result += "IV";
                    number -= 4;
                    continue;
                default:
                    result += "I";
                    number -= 1;
                    break;
            }
        }


        return result;
    }
}