using UnityEngine;
public class MergeSort : MonoBehaviour
{
    int[] AscendingSort(int[] arr1, int[] arr2)//2 Asecendnig Sorted Arrays
    {
        int[] arr3 = new int[arr1.Length + arr2.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] <= arr2[j])
            {
                arr3[k] = arr1[i];
                i++;
            }
            else
            {
                arr3[k] = arr2[j];
                j++;
            }
            k++;
        }
        while (i < arr1.Length)
        {
            arr3[k] = arr1[i];
            k++;
            i++;
        }
        while (j < arr2.Length)
        {
            arr3[k] = arr2[j];
            k++;
            j++;
        }
        return arr3;
    }
    int[] DescendingSort(int[] arr1, int[] arr2)//2 Asecendnig Sorted Arrays
    {
        int[] arr3 = new int[arr1.Length + arr2.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] >= arr2[j])
            {
                arr3[k] = arr1[i];
                i++;
            }
            else
            {
                arr3[k] = arr2[j];
                j++;
            }
            k++;
        }
        while (i < arr1.Length)
        {
            arr3[k] = arr1[i];
            k++;
            i++;
        }
        while (j < arr2.Length)
        {
            arr3[k] = arr2[j];
            k++;
            j++;
        }
        return arr3;
    }
    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }
    void Start()
    {
        Display(AscendingSort(new int[] { 1, 4, 7, 9 }, new int[] { 2, 3, 7, 8, 10 }));
        Display(DescendingSort(new int[] { 9, 8, 4, 1 }, new int[] { 10, 8, 4, 2 }));
    }
}