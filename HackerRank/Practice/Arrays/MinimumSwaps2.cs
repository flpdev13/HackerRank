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

                arr.Where(w => w < minor)

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
    }
}