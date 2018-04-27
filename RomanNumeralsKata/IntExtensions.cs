using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public static class IntExtensions
    {
        public static IEnumerable<int> GetWeightedDigits(this int number) =>
            Enumerable
                .Range(1, number.GetDigitsCount())
                .Select(i => (int) Math.Pow(10, i - 1))
                .Reverse()
                .Zip(number.GetDigits(), (weight, digit) => weight * digit)
                .Where(weightedDigit => weightedDigit != 0);

        public static int GetDigitsCount(this int number) =>
            number.ToString().Length;

        public static IEnumerable<int> GetDigits(this int number) =>
            number.ToString().Select(c => int.Parse(c.ToString()));
    }
}
