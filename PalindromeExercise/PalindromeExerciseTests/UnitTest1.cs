using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("fountain", false)]
        [InlineData("madam", true)]
        [InlineData("word", false)]

        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //act
            var actual = wordSmith.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
