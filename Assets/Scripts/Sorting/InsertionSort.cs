using UnityEngine;
public class InsertionSort : MonoBehaviour
{
    int[] AscendingSort(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = 1; i < copy.Length; i++)
        {
            int key = copy[i];
            int j = i - 1;
            while (j >= 0 && copy[j] > key)
            {
                copy[j + 1] = copy[j];
                j--;
            }
            copy[j + 1] = key;
        }
        return copy;
    }
    int[] DescendingSort(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = 1; i < copy.Length; i++)
        {
            int key = copy[i];
            int j = i - 1;
            while (j >= 0 && copy[j] < key)
            {
                copy[j + 1] = copy[j];
                j--;
            }
            copy[j + 1] = key;
        }
        return copy;
    }

    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }
    void Start()
    {
        int[] arr = new int[] { 20, 3, 4, 10, -40, 120 };
        Display(arr);
        Display(AscendingSort(arr));
        Display(DescendingSort(arr));
    }
}