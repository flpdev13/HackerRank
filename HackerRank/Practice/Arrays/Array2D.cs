namespace Practice.Arrays
{
    public static class Array2D
    {
        public static int Execute(int[][] arr)
        {
            int? sum = null;

            for (int i = 0; i < arr.Length - 2; i++)
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    int row = 1;
                    int temp = 0;

                    for (int a = i; a <= i + 2; a++)
                    {
                        if (row == 2)
                        {
                            temp += arr[a][j + 1];
                            ++row;
                            continue;
                        }

                        for (int b = j; b <= j + 2; b++)
                            temp += arr[a][b];

                        ++row;
                    }

                    if (sum == null || temp > sum)
                        sum = temp;
                }

            return sum.Value;
        }
    }
}