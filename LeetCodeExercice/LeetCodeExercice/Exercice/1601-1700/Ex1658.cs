namespace LeetCodeExercice.Exercice._1601_1700;

public class Ex1658
{
    public Ex1658()
    {
        
    }
    public int MinOperations(int[] nums, int x) {
        int total = nums.Sum();
        int target = total - x;
        int left = 0;
        int n = nums.Length;
        int maxLength = -1;
        int runningSum = 0;

        for (int right = 0; right < n; right++) {
            runningSum += nums[right];

            while (runningSum > target && left <= right) {
                runningSum -= nums[left];
                left++;
            }

            if (runningSum == target) {
                maxLength = Math.Max(maxLength, right - left + 1);
            }
        }

        return maxLength != -1 ? n - maxLength : -1;
    }
}