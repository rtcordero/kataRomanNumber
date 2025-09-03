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
    
    [Test]
    public void TwoIsII()
    {
        var converter = new RomanConverter();
        Assert.AreEqual("II", converter.ToRoman(2));
    }
    
    [Test]
    public void ThreeIsIII()
    {
        var converter = new RomanConverter();
        Assert.AreEqual("III", converter.ToRoman(3));
    }
    
        
    [Test]
    public void FourIsIV()
    {
        var converter = new RomanConverter();
        Assert.AreEqual("IV", converter.ToRoman(4));
    }
    
}