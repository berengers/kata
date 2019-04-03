using System;
using Xunit;

namespace RomanBills.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("XV", 15)]
        [InlineData("IX", 9)]
        [InlineData("-IX", -9)]
        [InlineData("-MDCLXVI", -1666)]
        [InlineData("-MCDLXVI", -1466)]
        public void Test_Convert_Roman_To_Integer__Should_Return_True(string romanSigns, int value)
        {
            Assert.Equal(Program.convertRomanToInteger(romanSigns), value);
        }
    }
}
