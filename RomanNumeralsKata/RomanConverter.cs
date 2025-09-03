namespace RomanNumeralsKata;

public class RomanConverter
{
    public string ToRoman(int number)
    {
        // lógica para convertir número a romano
        
        var result = "";

        for (int i = 0; i < number; i++)
        {
            result += "I";
        }
            

        return result;
        
    }
}