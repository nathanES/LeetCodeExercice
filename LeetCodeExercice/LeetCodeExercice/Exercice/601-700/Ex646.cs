namespace LeetCodeExercice.Exercice._601_700;

public class Ex646
{
    public Ex646()
    {
        int[][] i1 = new int[][]
        {
            new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }
        };
        if (FindLongestChain(i1) != 2)
            throw new Exception("faux");

        int[][] i2 = new int[][]
        {
            new int[] { 1, 2 }, new int[] { 7, 8 }, new int[] { 4, 5 }
        };
        if (FindLongestChain(i2) != 3)
            throw new Exception("faux");

    }
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));

        int cur = int.MinValue, ans = 0;

        foreach (var pair in pairs)
        {
            if (cur < pair[0])
            {
                cur = pair[1];
                ans++;
            }
        }

        return ans;
    }
}