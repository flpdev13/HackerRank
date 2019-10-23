using Practice.Arrays;
using Xunit;

namespace PracticeTest.Arrays
{
    public class ArrayLeftRotationTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 5, 1, 2, 3, 4 })]
        [InlineData(new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        [InlineData(new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 }, 13, new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 })]
        public void Test(int[] a, int d, int[] expected)
        {
            Assert.Equal(expected, ArrayLeftRotation.Execute(a, d));
        }
    }
}