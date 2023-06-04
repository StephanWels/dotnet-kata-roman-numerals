namespace RomanNumerals;

using Xunit;

public class RomanNumberParserTest
{
    [Theory]
    [InlineData("I", 1)]
    public void ParsesRomanNumbers(String romanNumber, int expectedResult)
    {
        RomanNumeralParser parser = new RomanNumeralParser();
        Assert.Equal(expectedResult, parser.Parse(romanNumber));
    }
}