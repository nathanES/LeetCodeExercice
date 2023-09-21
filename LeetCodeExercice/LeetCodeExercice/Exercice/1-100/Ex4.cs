namespace LeetCodeExercice.Exercice._1_100;

public class Ex4
{
    public Ex4()
    {
        // Example 1:
        // Input: nums1 = [1,3], nums2 = [2]
        // Output: 2.00000
        // Explanation: merged array = [1,2,3] and median is 2.
        var e1 = FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 });

        // Example 2:
        // Input: nums1 = [1,2], nums2 = [3,4]
        // Output: 2.50000
        // Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
        var e2 = FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 });
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            (nums1, nums2) = (nums2, nums1);
        }
        
        int m = nums1.Length;
        int n = nums2.Length;
        int low = 0, high = m;
        
        while (low <= high) {
            int partitionX = (low + high) / 2;
            int partitionY = (m + n + 1) / 2 - partitionX;
            
            int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            
            int minX = (partitionX == m) ? int.MaxValue : nums1[partitionX];
            int minY = (partitionY == n) ? int.MaxValue : nums2[partitionY];
            
            if (maxX <= minY && maxY <= minX) {
                if ((m + n) % 2 == 0) {
                    return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                } else {
                    return Math.Max(maxX, maxY);
                }
            } else if (maxX > minY) {
                high = partitionX - 1;
            } else {
                low = partitionX + 1;
            }
        }
        
        throw new ArgumentException("Input arrays are not sorted.");
    }
}