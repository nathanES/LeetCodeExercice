namespace LeetCodeExercice.Exercice._1601_1700;

public class Ex1672
{
    public Ex1672()
    {
        var i1 = new int[][]
        {
            new int[]{1,2,3},
            new int[]{3,2,1}
        };
        if (MaximumWealth(i1) != 6)
            throw new Exception("ex 1 : faux");
    
        var i2 = new int[][]
        {
            new int[]{1,5},
            new int[]{7,3},
            new int[]{3,5}
        };
        if (MaximumWealth(i2) != 10)
            throw new Exception("ex 2 : faux");
    
        var i3 = new int[][]
        {
            new int[]{2,8,7},
            new int[]{7,1,3},
            new int[]{1,9,5}
        };
        if (MaximumWealth(i3) != 17)
            throw new Exception("ex 3 : faux");
   
    }
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;
    
        foreach (int[] account in accounts)
        {
            int temp = 0;
            
            foreach (int money in account)
            {
                temp += money;
            }

            max = Math.Max(temp, max);
        }

        return max;
    }

}