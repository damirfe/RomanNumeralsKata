using System.Collections.Generic;
using Xunit;

namespace RomanNumeralsKata.UnitTests
{
    public class IntExtensionsTests
    {
        [Theory]
        [MemberData(nameof(TestCases))]
        public void Should_Return1_When_Given1(int number, int[] expectedParts)
        {
            IEnumerable<int> parts = number.GetWeightedDigits();

            Assert.Equal(expectedParts, parts);
        }

        public static IEnumerable<object[]> TestCases()
        {
            yield return new object[] { 1, new[] { 1 } };
            yield return new object[] { 10, new[] { 10 } };
            yield return new object[] { 12, new[] { 10, 2 } };
            yield return new object[] { 1002, new[] { 1000, 2 } };
            yield return new object[] { 1020, new[] { 1000, 20 } };
            yield return new object[] { 1023, new[] { 1000, 20, 3 } };
            yield return new object[] { 1200, new[] { 1000, 200 } };
            yield return new object[] { 1203, new[] { 1000, 200, 3 } };
            yield return new object[] { 1230, new[] { 1000, 200, 30 } };
            yield return new object[] { 1234, new[] { 1000, 200, 30, 4 } };
        }
    }
}
