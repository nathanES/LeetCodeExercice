namespace LeetCodeExercice.Exercice._1401_1500;

public class Ex1480
{
    public Ex1480()
    {
        if (RunningSum(new int[] { 1, 2, 3, 4 }) != new int[] { 1, 3, 6, 10 })
            throw new Exception("ex 1 : faux");
        if (RunningSum(new int[] { 1, 1, 1, 1, 1 }) != new int[] { 1, 2, 3, 4, 5 })
            throw new Exception("ex 2 : faux");
        if (RunningSum(new[] { 3, 1, 2, 10, 1 }) != new int[] { 3, 4, 6, 16, 17 })
            throw new Exception("ex 3 : faux");

    }
    public int[] RunningSum(int[] nums)
    {
        int[] t = new int [nums.Length];
        t[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            t[i] = nums[i] + t[i - 1];
        }

        return t;
    }

}