namespace LeetCodeExercice.Exercice._1501_1600;

public class Ex1512
{
    public Ex1512()
    {
        var e1 = NumIdenticalPairs(new[] { 1, 2, 3, 1, 1, 3 });
        
    }
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int result = 0;
        foreach (int num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
                result += count[num];
            }
            else
            {
                count.Add(num,0);
            }
        }
        return result;
    }
}