using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public string Parse(int number) => 
            number
                .GetWeightedDigits()
                .Select(RomanNumeralMappings.ToRomanNumeral)
                .Join(string.Empty);
    }
}
