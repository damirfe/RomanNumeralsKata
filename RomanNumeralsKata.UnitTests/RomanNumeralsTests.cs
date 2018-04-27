using Xunit;

namespace RomanNumeralsKata.UnitTests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(2, "II")]
        [InlineData(12, "XII")]
        [InlineData(1058, "MLVIII")]
        public void Should_ReturnRomanNumber_When_GivenNumber(int number, string expectedRomanNumber)
        {
            string romanNumber = new RomanNumerals().Parse(number);

            Assert.Equal(expectedRomanNumber, romanNumber);
        }


    }
}
