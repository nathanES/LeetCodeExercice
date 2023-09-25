namespace LeetCodeExercice.Sample;

public class BinarySearch
{
    //Peut être opérer sur des array, des string, ... mais il doivent obligatoirement être triés
    public BinarySearch()
    {
        // BinarySearchRecursiveEntry()
    }

    #region Recurive

    public static bool BinarySearchRecursiveEntry(int[] array, int x) =>
        BinarySearchRecursive(array, x, 0, array.Length - 1);
    public static bool BinarySearchRecursive(int[] array, int x, int left, int right)
    {
        if (left > right)
            return false;
        
        int mid = (left + right) / 2; //ou left+ ((right-left)/2) en cas d'overflow
        if (array[mid] == x)
            return true;
        else if (x < array[mid])
            return BinarySearchRecursive(array, x, left, mid - 1);
        else
            return BinarySearchRecursive(array, x, mid + 1, right);
    }
    

    #endregion

    #region Iterative

    public static bool BinarySearchIterative(int[] array, int x)
    {
        int left = 0, right = array.Length -1;

        while (left <= right)
        {
            int mid = (left + right) / 2; //ou left+ ((right-left)/2) en cas d'overflow
            if (array[mid] == x)
                return true;
            else if (x < array[mid])
                right = mid - 1; //left = left
            else
                left = mid + 1;//right = right
            
        }

        return false;
    }

    #endregion
}