using Practice.WarmUpChallenges;
using Xunit;

namespace PracticeTest
{
    public class WarmUpChallengesTest
    {
        [Theory]
        [InlineData(9, new int[] { 10,20,20,10,10,30,50,10,20 }, 3)]
        [InlineData(10, new int[] { 1,1,3,1,2,1,3,3,3,3 }, 4)]
        public void SockMerchantTest(int n, int[] ar, int expected)
        {
            Assert.Equal(expected, SockMerchant.Execute(n, ar));
        }

        [Theory]
        [InlineData(8, "UDDDUDUU", 1)]
        [InlineData(12, "DDUUDDUDUUUD", 2)]
        public void CountingValleysTest(int n, string s, int expected)
        {
            Assert.Equal(expected, CountingValleys.Execute(n, s));
        }

        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
        [InlineData(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
        [InlineData(new int[] { 0, 0, 0, 1, 0, 0 }, 3)]
        public void JumpingOnTheCloudsTest(int[] c, int expected)
        {
            Assert.Equal(expected, JumpingOnTheClouds.Execute(c));
        }

        [Theory]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        [InlineData("gfcaaaecbg", 547602, 164280)]
        public void RepeatedStringTest(string s, long n, long expected)
        {
            Assert.Equal(expected, RepeatedString.Execute(s, n));
        }
    }
}