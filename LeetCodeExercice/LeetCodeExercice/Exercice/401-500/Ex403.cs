namespace LeetCodeExercice.Exercice._401_500;

public class Ex403
{
    public Ex403()
    {
        int[] ex1i = new int[] { 0, 1, 3, 5, 6, 8, 12, 17 };
        if (CanCross(ex1i) != true)
            throw new Exception("ex 1 : faux");

        int[] ex2i = new int[] { 0, 1, 2, 3, 4, 8, 9, 11 };
        if (CanCross(ex2i) != false)
            throw new Exception("ex 2 : faux");

    }
    public bool CanCross(int[] stones)
    {
        int n = stones.Length;

        Dictionary<int, HashSet<int>> dp = new Dictionary<int, HashSet<int>>();
        foreach (int stone in stones)
        {
            dp[stone] = new HashSet<int>();
        }

        dp[0].Add(0);

        for (int i = 0; i < n; i++)
        {
            foreach (int k in dp[stones[i]])
            {
                for (int step = k - 1; step <= k + 1; step++)
                {
                    if (step != 0 && dp.ContainsKey(stones[i] + step))
                    {
                        dp[stones[i] + step].Add(step);
                    }
                }
            }
        }

        return dp[stones[n - 1]].Count > 0;
    }
}