using System;
using System.Collections.Generic;
using Xunit;

namespace bomb.test
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Return_In_Strings_0123456789()
        {
            var numbers = new string[10] {
                " _ " +
                "| |" +
                "|_|",

                "   " +
                "  |" +
                "  |",

                " _ " +
                " _|" +
                "|_ ",

                " _ " +
                " _|" +
                " _|",

                "   " +
                "|_|" +
                "  |",

                " _ " +
                "|_ " +
                " _|",

                " _ " +
                "|_ " +
                "|_|",

                " _ " +
                "  |" +
                "  |",

                " _ " +
                "|_|" +
                "|_|",

                " _ " +
                "|_|" +
                " _|",
            };
            var combis = new List<string>(new string[] { 
                " _     _     _  _  _  _  _ |_ |_||_   || ||_  _||_|  | _|  ||_|  ||_| _||_ |_|  |",
                " _  _  _  _     _  _  _  _  _||_||_|  |  ||_ | ||_ |_  _| _| _|  |  ||_||_||_||_|"
            });
            var resp = new string[] { "0123456789", "765432189" };
            Assert.Equal(resp, Program.convertToStringCombi(combis));
        }

        [Fact]
        public void Should_Return_A_Zero_Value()
        {
            var values = new string[] { "123456788", "098765432" };
            Assert.Equal(0, Program.findSolution(values));
        }
        [Fact]
        public void Sould_Return_The_Value_123456789()
        {
            var value = new string[] { "123456789" };
            Assert.Equal(123456789, Program.findSolution(value));
        }
    }
}
