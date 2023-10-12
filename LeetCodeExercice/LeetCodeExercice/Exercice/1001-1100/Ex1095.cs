namespace LeetCodeExercice;

public class Ex1095
{
    public Ex1095()
    {
        
    }
public int FindInMountainArray(int target, MountainArray mountainArr) {
        int peakIndex = FindPeakIndex(mountainArr);
        
        // Search in the left side of the peak
        int leftIndex = BinarySearch(mountainArr, target, 0, peakIndex, true);
        if (leftIndex != -1)
            return leftIndex;
        
        // Search in the right side of the peak
        int rightIndex = BinarySearch(mountainArr, target, peakIndex + 1, mountainArr.Length() - 1, false);
        return rightIndex;
    }
    
    private int FindPeakIndex(MountainArray mountainArr) {
        int left = 0;
        int right = mountainArr.Length() - 1;
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                left = mid + 1;
            else
                right = mid;
        }
        
        return left;
    }
    
    private int BinarySearch(MountainArray mountainArr, int target, int left, int right, bool ascending) {
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int midValue = mountainArr.Get(mid);
            
            if (midValue == target)
                return mid;
            
            if (ascending) {
                if (midValue < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            } else {
                if (midValue > target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        
        return -1;
    }
}
public class MountainArray {
      public int Get(int index) {return -1;}
      public int Length() {return -1;}
}