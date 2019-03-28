using System;
using Xunit;

namespace Anagrams.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("lie", "rate", "atelier")]
        [InlineData("tile", "are", "atelier")]
        public void Should_Be_True_If_It_Is_An_Atelier_Anagram(string word1, string word2, string anagram)
        {
            Assert.True(Program.isAnagram(word1, word2, anagram));
        }
        [Theory]
        [InlineData("liz", "rate", "atelier")]
        [InlineData("tile", "aee", "atelier")]
        public void Should_Be_False_If_It_Is_An_Atelier_Anagram(string word1, string word2, string anagram)
        {
            Assert.False(Program.isAnagram(word1, word2, anagram));
        }
    }
}
