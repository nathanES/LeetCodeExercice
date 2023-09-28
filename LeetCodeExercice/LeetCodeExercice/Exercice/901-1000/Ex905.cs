namespace LeetCodeExercice.Exercice._901_1000;

public class Ex905
{
    public Ex905()
    {
        var e1 = SortArrayByParity(new[] { 3, 1, 2, 4 });
        var e2 = SortArrayByParity(new[] { 0 });

    }
    public int[] SortArrayByParity(int[] nums)
    {
        int[] result = new int[nums.Length];
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0)
            {
                result[rightPointer] = nums[i];
                rightPointer--;
            }
            else
            {
                result[leftPointer] = nums[i];
                leftPointer++;
            }
        }

        return result;
    }
    public int[] SortArrayByParityCorrection(int[] nums)
    {
        List<int> evenNumbers = nums.Where(i => i % 2 == 0).ToList();
        List<int> oddNumbers = nums.Where(j => j % 2 != 0).ToList();
        
        evenNumbers.AddRange(oddNumbers);
        swap
        return evenNumbers.ToArray();
    }
}