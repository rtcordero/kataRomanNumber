using RomanNumeralsKata;

namespace Tests;

[TestFixture]
public class RomanConverterTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9, "IX")]
    [TestCase(10, "X")]
    [TestCase(20, "XX")]
    [TestCase(50, "L")]
    
    public void ConvertsNumberToRoman(int number, string expected)
    {
        var converter = new RomanConverter();
        var result = converter.ToRoman(number);
        Assert.AreEqual(expected, result);
    }
}