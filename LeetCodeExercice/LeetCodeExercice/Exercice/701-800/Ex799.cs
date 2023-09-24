namespace LeetCodeExercice.Exercice._701_800;

public class Ex799
{
    public Ex799()
    {
        
    }

    public double ChampagneTowerCorrection(int poured, int query_row, int query_glass)
    {
        double[][] tower = new double[query_row + 1][];
        for (int i = 0; i <= query_row; i++) {
            tower[i] = new double[i + 1];
        }
        
        tower[0][0] = poured;

        for (int row = 0; row < query_row; row++) {
            for (int glass = 0; glass < tower[row].Length; glass++) {
                double excess = (tower[row][glass] - 1) / 2.0;
                if (excess > 0) {
                    tower[row + 1][glass] += excess;
                    tower[row + 1][glass + 1] += excess;
                }
            }
        }

        return Math.Min(1.0, tower[query_row][query_glass]);
    }
    
    //Ne fonctionne pas
    // public double ChampagneTower(int poured, int query_row, int query_glass)
    // {
    //     Dictionary<(int, int), double> memo = new Dictionary<(int, int), double>();
    //     return ChampagneTowerHelper(poured, query_row, query_glass, memo);
    // }
    //
    // public double ChampagneTowerHelper(int poured, int query_row, int query_glass, Dictionary<(int,int),double> memo)
    // {
    //     if (memo.ContainsKey((query_row, query_glass)))
    //         return memo[(query_row, query_glass)];
    //     if (query_row == 0 && query_glass == 0)
    //         return poured - 1;
    // }
}