namespace LeetCodeExercice.Exercice._1301_1400;

public class Ex1337
{
    public Ex1337()
    {
        // Input: mat =
        // [[1,1,0,0,0],
        // [1,1,1,1,0],
        // [1,0,0,0,0],
        // [1,1,0,0,0],
        // [1,1,1,1,1]], 
        // k = 3
        // Output: [2,0,3]
        int[][] i1 = new[]
        {
            new[] { 1, 1, 0, 0, 0 },
            new[] { 1, 1, 1, 1, 0 },
            new[] { 1, 0, 0, 0, 0 },
            new[] { 1, 1, 0, 0, 0 },
            new[] { 1, 1, 1, 1, 1 }
        };
        var ex1 = KWeakestRows(i1, 3);
        // Input: mat = 
        // [[1,0,0,0],
        // [1,1,1,1],
        // [1,0,0,0],
        // [1,0,0,0]], 
        // k = 2
        // Output: [0,2]
        int[][] i2 = new[]
        {
            new[] { 1, 0, 0, 0 },
            new[] { 1, 1, 1, 1 },
            new[] { 1, 0, 0, 0 },
            new[] { 1, 0, 0, 0 }
        };
        var ex2 = KWeakestRows(i2, 2);
    }
    public int[] KWeakestRows(int[][] mat, int k)
    {
        Dictionary<int, int> dicRankNumber = new Dictionary<int, int>();

        int i = 0;
        foreach (int[] line in mat)
        {
            int nbrSoldier = 0;
            foreach (int person in line)
            {
                if (person == 1)
                    nbrSoldier++;
            }
            dicRankNumber.Add(i,nbrSoldier);
            i++;
        }
        var sortedDicRankNumber = from entry in dicRankNumber orderby entry.Value ascending select entry;
        int y = 0;
        int[] result = new int[k];
        foreach (var rank in sortedDicRankNumber)
        {
            if (y==k)
                break;
            result[y] = rank.Key;
            y++;
        }

        return result;
    }
    public int[] KWeakestRowsSortCorrection(int[][] mat, int k) {
        var rowStrengths = mat.Select((row, i) => new { Strength = row.Sum(), Index = i })
            .OrderBy(x => x.Strength)
            .ThenBy(x => x.Index)
            .Take(k)
            .Select(x => x.Index)
            .ToArray();
        return rowStrengths;
    }
}