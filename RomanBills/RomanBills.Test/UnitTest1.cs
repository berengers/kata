using System;
using Xunit;

namespace RomanBills.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Convert_Roman_To_Integer__Should_Return_True()
        {
            Assert.Equal(Program.convertRomanToInteger(""), 0);
            Assert.Equal(Program.convertRomanToInteger("-"), 0);
            Assert.Equal(Program.convertRomanToInteger("XV"), 15);
            Assert.Equal(Program.convertRomanToInteger("VX"), 5);
            Assert.Equal(Program.convertRomanToInteger("-VX"), -5);
            Assert.Equal(Program.convertRomanToInteger("-MDCLXVI"), -1666);
            Assert.Equal(Program.convertRomanToInteger("-MCDLXVI"), -1466);
        }
    }
}
