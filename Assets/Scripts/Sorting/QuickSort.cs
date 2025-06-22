using UnityEngine;
public class QuickSort : MonoBehaviour//Divide and Conquer
{
    int PartitionAscendent(int[] arr, int i, int j)
    {
        int piv = i;
        while (true)
        {
            while (arr[piv] <= arr[j] && piv != j)
            {
                j--;
            }
            if (piv == j)
            {
                break;
            }
            else if (arr[piv] > arr[j])
            {
                (arr[piv], arr[j]) = (arr[j], arr[piv]);
                piv = j;
            }
            while (arr[piv] >= arr[i] && piv != i)
            {
                i++;
            }
            if (piv == i)
            {
                break;
            }
            else if (arr[piv] < arr[i])
            {
                (arr[piv], arr[i]) = (arr[i], arr[piv]);
                piv = i;
            }
        }
        return piv;
    }
    int PartitionDescendent(int[] arr, int i, int j)
    {
        int piv = i;
        while (true)
        {
            while (arr[piv] >= arr[j] && piv != j)
            {
                j--;
            }
            if (piv == j)
            {
                break;
            }
            else if (arr[piv] < arr[j])
            {
                (arr[piv], arr[j]) = (arr[j], arr[piv]);
                piv = j;
            }
            while (arr[piv] <= arr[i] && piv != i)
            {
                i++;
            }
            if (piv == i)
            {
                break;
            }
            else if (arr[piv] > arr[i])
            {
                (arr[piv], arr[i]) = (arr[i], arr[piv]);
                piv = i;
            }
        }
        return piv;
    }
    void SortAscendent(int[] arr, int l, int h)
    {
        if (l < h)
        {
            int piv = PartitionAscendent(arr, l, h);
            SortAscendent(arr, l, piv - 1);
            SortAscendent(arr, piv + 1, h);
        }
    }
    void SortDescendent(int[] arr, int l, int h)
    {
        if (l < h)
        {
            int piv = PartitionDescendent(arr, l, h);
            SortDescendent(arr, l, piv - 1);
            SortDescendent(arr, piv + 1, h);
        }
    }
    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }
    void Start()
    {
        int[] arr1 = new int[] { 3, 6, 32, 1, 5, 2 };
        int[] arr2 = new int[] { 3, 6, 32, 1, 5, 2 };
        SortAscendent(arr1, 0, arr1.Length - 1);
        Debug.Log("arr1 asc");
        Display(arr1);
        SortDescendent(arr2, 0, arr1.Length - 1);
        Debug.Log("arr2 des");
        Display(arr2);
    }
}