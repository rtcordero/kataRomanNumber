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
    [TestCase(11, "XI")]
    [TestCase(12, "XII")]
    [TestCase(13, "XIII")]
    [TestCase(14, "XIV")]
    [TestCase(15, "XV")]
    [TestCase(16, "XVI")]
    [TestCase(17, "XVII")]
    [TestCase(18, "XVIII")]
    [TestCase(19, "XIX")]
    [TestCase(20, "XX")]
    [TestCase(21, "XXI")]
    [TestCase(22, "XXII")]
    [TestCase(23, "XXIII")]
    [TestCase(24, "XXIV")]
    [TestCase(25, "XXV")]
    [TestCase(26, "XXVI")]
    [TestCase(27, "XXVII")]
    [TestCase(28, "XXVIII")]
    [TestCase(29, "XXIX")]
    [TestCase(30, "XXX")]
    [TestCase(40, "XL")]
    [TestCase(41, "XLI")]
    [TestCase(42, "XLII")]
    [TestCase(43, "XLIII")]
    [TestCase(44, "XLIV")]
    [TestCase(45, "XLV")]
    [TestCase(46, "XLVI")]
    [TestCase(47, "XLVII")]
    [TestCase(48, "XLVIII")]
    [TestCase(49, "XLIX")]
    [TestCase(50, "L")]
    [TestCase(60, "LX")]
    [TestCase(90, "XC")]
    [TestCase(100, "C")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    
    public void ConvertsNumberToRoman(int number, string expected)
    {
        var converter = new RomanConverter();
        var result = converter.ToRoman(number);
        Assert.AreEqual(expected, result);
    }
}