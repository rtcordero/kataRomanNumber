using RomanNumeralsKata;

namespace Tests;

[TestFixture]
public class RomanConverterTests
{
    [Test]
    public void OneIsI()
    {
        var converter = new RomanConverter();
        Assert.AreEqual("I", converter.ToRoman(1));
    }
}