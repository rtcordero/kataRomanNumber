namespace RomanNumeralsKata;

public class RomanConverter
{
    public string ToRoman(int number)
    {
        // lógica para convertir número a romano
        
        if (number == 1)
        {
          return "I";  
        }
        if (number == 2)
        {
          return "II";  
        }
        if (number == 3)
        {
          return "III";  
        }
        return "";
        
    }
}