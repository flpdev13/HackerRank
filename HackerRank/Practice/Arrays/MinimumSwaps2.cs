using System.Linq;

namespace Practice.Arrays
{
    public static class MinimumSwaps2
    {
        public static int SelectionSort(int[] arr)
        {
            int swaps = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minor = arr[i];
                int index = -1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < minor)
                    {
                        minor = arr[j];
                        index = j;
                    }
                }

                if (index > -1)
                {
                    int aux = arr[i];
                    arr[i] = minor;
                    arr[index] = aux;
                    ++swaps;
                }
            }

            return swaps;
        }

        public static int Execute(int[] arr)
        {
            int swaps = 0;
            int index = -1;
            bool[] testList = new bool[arr.Length];

            var list = arr.Select(s => new { Value = s, Index = ++index })
                          .OrderBy(o => o.Value)
                          .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (testList[i] || list[i].Index == i)
                    continue;

                int cycle = 0;
                int j = i;

                while (!testList[j])
                {
                    testList[j] = true;
                    j = list[j].Index;
                    ++cycle;
                }

                if (cycle > 0)
                    swaps += (cycle - 1);
            }

            return swaps;
        }
    }
}