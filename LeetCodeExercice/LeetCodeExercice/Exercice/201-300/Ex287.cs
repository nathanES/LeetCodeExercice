namespace LeetCodeExercice.Exercice._201_300;

public class Ex287
{
    public Ex287()
    {
        int[] i1 = new[] { 1, 30, 4, 2, 2 };
        var e1 = FindDuplicateSFPointer(i1);
        int[] i2 = new[] { 3, 1, 3, 4, 2 };
        var e2 = FindDuplicateSFPointer(i2);
    }
    public int FindDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int y = i+1; y < nums.Length; y++)
            {
                if (nums[i] == nums[y])
                    return nums[i];
            }
        }

        return -1;
    }
    //SlowFastPointer
    //On peut utiliser les 2 pointeurs à cause de 1≤nums[i]≤n
    public int FindDuplicateSFPointer(int[] nums)
    {
        int slow = nums[0];
        int fast = nums[0];
        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow==fast)
                break;
        }

        slow = nums[0];
        while (slow!= fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}