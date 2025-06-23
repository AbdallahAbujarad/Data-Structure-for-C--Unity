using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    int Search(int[] sortedArray, int key)
    {
        int l = 0;
        int h = sortedArray.Length - 1;
        HeapSort.AscendingSort(sortedArray);
        while (l <= h)
        {
            int m = (l + h) / 2;
            if (key == sortedArray[m])
            {
                return m;
            }
            if (key > sortedArray[m])
            {
                l = m + 1;
            }
            if (key < sortedArray[m])
            {
                h = m - 1;
            }
        }
        return -1;
    }
    void Start()
    {
        int[] arr = new int[] { 3, 1, 20, -1, 15 };
        Debug.Log(Search(arr, 3));
        Debug.Log(Search(arr, 17));
    }
}
