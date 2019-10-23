namespace Practice.Arrays
{
    public static class MinimumSwaps2
    {
        public static int Execute(int[] arr)
        {
            int swaps = 0;

            // Implementar Quick Sort

            // Selection Sort (correto porem muito demorado em vetores grandes)
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    int minor = arr[i];
            //    int index = -1;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < minor)
            //        {
            //            minor = arr[j];
            //            index = j;
            //        }
            //    }

            //    if (index > -1)
            //    {
            //        int aux = arr[i];
            //        arr[i] = minor;
            //        arr[index] = aux;
            //        ++swaps;
            //    }
            //}

            return swaps;
        }
    }
}