using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rotator", true)]
        [InlineData("wow", true)]
        [InlineData("noon", true)]
        [InlineData("bingo", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //ARRANGE
            var wordsmith = new Wordsmith();
            //ACT
            var actual = wordsmith.IsAPalindrome(word);
            //ASSERT
            Assert.Equal(expected, actual);

        }
    }
}
