namespace LeetCodeExercice.Exercice._401_500;

public class Ex456
{
    public Ex456()
    {
        var e1 = Find132pattern(new[] { 1, 2, 3, 4 });
        var e2 = Find132pattern(new[] { 3,1,4,2 });
        var e3 = Find132pattern(new[] { -1, 3, 2, 0 });
    }
    
    public bool Find132pattern(int[] nums) {
        //nums[i] < nums[k] < nums[j]
        // i < j < k
        Stack<int> stack = new Stack<int>();
        int third = int.MinValue;

        for (int i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] < third) return true;
            while (stack.Count > 0 && stack.Peek() < nums[i]) {
                third = stack.Pop();
            }
            stack.Push(nums[i]);
        }
        return false;
    }
    
}