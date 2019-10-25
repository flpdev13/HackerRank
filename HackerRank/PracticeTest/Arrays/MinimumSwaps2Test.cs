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
        [InlineData(new int[] { 2, 31, 1, 38, 29, 5, 44, 6, 12, 18, 39, 9, 48, 49, 13, 11, 7, 27, 14, 33, 50, 21, 46, 23, 15, 26, 8, 47, 40, 3, 32, 22, 34, 42, 16, 41, 24, 10, 4, 28, 36, 30, 37, 35, 20, 17, 45, 43, 25, 19 }, 46)]
        public void SelectionSortTest(int[] arr, int expected)
        {
            Assert.Equal(expected, MinimumSwaps2.SelectionSort(arr));
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3, 4, 1, 5 }, 3)]
        [InlineData(new int[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
        [InlineData(new int[] { 2,31,1,38,29,5,44,6,12,18,39,9,48,49,13,11,7,27,14,33,50,21,46,23,15,26,8,47,40,3,32,22,34,42,16,41,24,10,4,28,36,30,37,35,20,17,45,43,25,19 }, 46)]
        public void Test(int[] arr, int expected)
        {
            Assert.Equal(expected, MinimumSwaps2.Execute(arr));
        }
    }
}