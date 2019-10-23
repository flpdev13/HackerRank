using System.Linq;

namespace Practice.Arrays
{
    public static class ArrayLeftRotation
    {
        public static int[] Execute(int[] a, int d)
        {
            var list = a.ToList();

            for (int r = 1; r <= d; r++)
            {
                list.Add(list.First());
                list.RemoveAt(0);
            }

            return list.ToArray();
        }
    }
}