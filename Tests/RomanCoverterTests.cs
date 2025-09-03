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
    public void ConvertsNumberToRoman(int number, string expected)
    {
        var converter = new RomanConverter();
        var result = converter.ToRoman(number);
        Assert.AreEqual(expected, result);
    }
}