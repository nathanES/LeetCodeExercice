namespace LeetCodeExercice.Exercice._301_400;

public class Ex377
{
    public Ex377()
    {
        int[] i1 = new int[] { 1, 2, 3 };
        if (CombinationSum4(i1, 4) != 7)
            throw new Exception("ex 1 : faux");
            
        int[] i2 = new int[] { 9 };
        if (CombinationSum4(i2,3) != 0)
            throw new Exception("ex 2 : faux");

    }
    public int CombinationSum4(int[] nums, int target)
    {
        int[] dp = new int[target + 1];
        dp[0] = 1;
        
        for (int i = 1; i <= target; i++) {
            foreach (int num in nums) {
                if (i - num >= 0) {
                    dp[i] += dp[i - num];
                }
            }
        } 
        return dp[target];
    }

}