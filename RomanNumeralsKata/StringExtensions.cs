﻿using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public static class StringExtensions
    {
        public static string Join(this IEnumerable<string> sequence, string separator) =>
            string.Join(separator, sequence);
    }
}
