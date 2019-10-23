using Practice.Arrays;
using System.Collections.Generic;
using Xunit;

namespace PracticeTest.Arrays
{
    public class Array2DTest
    {
        public class ItemTest
        {
            public int Expected { get; set; }
            public int[][] Parameter { get; set; }
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[] {
                new List<ItemTest> {
                    new ItemTest
                    {
                        Expected = 19,
                        Parameter = new int[6][]
                    {
                        new int[6] { 1, 1, 1, 0, 0, 0 },
                        new int[6] { 0, 1, 0, 0, 0, 0 },
                        new int[6] { 1, 1, 1, 0, 0, 0 },
                        new int[6] { 0, 0, 2, 4, 4, 0 },
                        new int[6] { 0, 0, 0, 2, 0, 0 },
                        new int[6] { 0, 0, 1, 2, 4, 0 }
                    }
                    },
                    new ItemTest
                    {
                        Expected = 13,
                        Parameter =  new int[6][]
                        {
                            new int[6] { 1, 1, 1, 0, 0, 0 },
                            new int[6] { 0, 1, 0, 0, 0, 0 },
                            new int[6] { 1, 1, 1, 0, 0, 0 },
                            new int[6] { 0, 9, 2, -4, -4, 0 },
                            new int[6] { 0, 0, 0, -2, 0, 0 },
                            new int[6] { 0, 0, -1, -2, -4, 0 }
                        }
                    },
                    new ItemTest
                    {
                        Expected = 0,
                        Parameter = new int[6][]
                        {
                            new int[6] { 1, 1, -1, 0, 0, 0 },
                            new int[6] { 0, -1, 0, 0, 0, 0 },
                            new int[6] { -1, -1, -1, 0, 0, 0 },
                            new int[6] { 0, -9, 2, -4, -4, 0 },
                            new int[6] { -7, 0, 0, -2, 0, 0 },
                            new int[6] { 0, 0, -1, -2, -4, 0 }
                        }
                    },
                    new ItemTest
                    {
                        Expected = -6,
                        Parameter = new int[6][]
                        {
                            new int[6] { -1, -1, 0, -9, -2, -2 },
                            new int[6] { -2, -1, -6, -8, -2, -5 },
                            new int[6] { -1, -1, -1, -2, -3, -4 },
                            new int[6] { -1, -9, -2, -4, -4, -5 },
                            new int[6] { -7, -3, -3, -2, -9, -9 },
                            new int[6] { -1, -3, -1, -2, -4, -5 }
                        }
                    },
                    new ItemTest
                    {
                        Expected = 28,
                        Parameter = new int[6][]
                        {
                            new int[6] { -9, -9, -9, 1, 1, 1 },
                            new int[6] { 0, -9, 0, 4, 3, 2 },
                            new int[6] { -9, -9, -9, 1, 2, 3 },
                            new int[6] { 0, 0, 8, 6, 6, 0 },
                            new int[6] { 0, 0, 0, -2, 0, 0 },
                            new int[6] { 0, 0, 1, 2, 4, 0 }
                        }
                    }
                }
            }
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(List<ItemTest> items)
        {
            foreach (var item in items)
                Assert.Equal(item.Expected, Array2D.Execute(item.Parameter));
        }
    }
}