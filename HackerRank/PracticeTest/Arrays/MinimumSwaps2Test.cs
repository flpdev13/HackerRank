using Practice.Arrays;
using Xunit;

namespace PracticeTest.Arrays
{
    public class MinimumSwaps2Test
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3, 4, 1, 5 }, 3)]
        [InlineData(new int[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
        public void Test(int[] arr, int expected)
        {
            Assert.Equal(expected, MinimumSwaps2.Execute(arr));
        }
    }
}