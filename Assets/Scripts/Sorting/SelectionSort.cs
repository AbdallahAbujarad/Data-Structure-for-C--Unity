using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    int[] SortAscending(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = 0; i < copy.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < copy.Length; j++)
            {
                if (copy[j] < copy[minIndex])
                {
                    minIndex = j;
                }
            }
            (copy[minIndex], copy[i]) = (copy[i], copy[minIndex]);
        }
        return copy;
    }
    int[] SortDescending(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = 0; i < copy.Length; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < copy.Length; j++)
            {
                if (copy[maxIndex] < copy[j])
                {
                    maxIndex = j;
                }
            }
            (copy[maxIndex], copy[i]) = (copy[i], copy[maxIndex]);
        }
        return copy;
    }
    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }
    void Start()
    {
        int[] ints = new int[] { 1, 7, -3, 170, 6, 2 };
        Display(SortAscending(ints));
        Display(SortDescending(ints));
    }
}
