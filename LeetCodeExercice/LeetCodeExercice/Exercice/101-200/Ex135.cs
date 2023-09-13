namespace LeetCodeExercice.Exercice._101_200;

public class Ex135
{
    public Ex135()
    {
        RemoveDuplicates(new[] { 1, 1, 2 });
        RemoveDuplicates(new[] { 0,0,1,1,1,2,2,3,3,4});

        //RemoveElement(new[] { 0,1,2,2,3,0,4,2}, 2);
        
        
        
        
        int[] i1 = new[] { 1, 0, 2 };
        var ex1 = Candy(i1);
        int[] i2 = new[] { 1, 2, 2 };
        var ex2 = Candy(i2); 
        int[] i3 = new[] { 1,3,2,2,1 };
        var ex3 = Candy(i3); 
    }
    
    public int Candy(int[] ratings)
    {
        int n = ratings.Length;
        int[] candies = new int[n];
        Array.Fill(candies, 1);

        for (int i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }

        for (int i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        int totalCandies = 0;
        foreach (int candy in candies) {
            totalCandies += candy;
        }

        return totalCandies;
    }

    //Exemple 1
    // Input: nums = [3,2,2,3], val = 3
    // Output: 2, nums = [2,2,_,_]
    //Exemple 2
    // Input: nums = [0,1,2,2,3,0,4,2], val = 2
    // Output: 5, nums = [0,1,4,0,3,_,_,_]
    public int RemoveElement(int[] nums, int val)
    {
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == val)
            {
                for (int y = i ; y < length-1; y++)
                {
                    nums[y] = nums[y+1];
                }
                length--;
                i--;
            }
        }
        Array.Fill(nums,0,length,nums.Length - length );
        return length;
    }
    
    //Exemple 1 :
    // Input: nums = [1,1,2]
    // Output: 2, nums = [1,2,_]
    //Exemple 2 :
    // Input: nums = [0,0,1,1,1,2,2,3,3,4]
    // Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
    public int RemoveDuplicates(int[] nums)
    {
        int length = nums.Length;
        for (int i = 0; i < length-1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                for (int y = i; y < length-1; y++)
                {
                    nums[y] = nums[y + 1];
                }

                length--;
                i--;
            }
        }
Array.Fill(nums,0,length, nums.Length - length);
        return length;
    }
}