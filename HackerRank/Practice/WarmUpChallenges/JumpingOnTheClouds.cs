namespace Practice.WarmUpChallenges
{
    public static class JumpingOnTheClouds
    {
        public static int Execute(int[] c)
        {
            int jump = 0, i = 0;

            while (i < c.Length - 1)
            {
                int a = i + 2;

                if (a < c.Length && c[a] == 0)
                {
                    ++jump;
                    i = a;
                    continue;
                }

                ++jump;
                ++i;
            }

            return jump;
        }
    }
}