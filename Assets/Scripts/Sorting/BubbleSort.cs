using UnityEngine;
using UnityEngine.Rendering;

public class BubbleSort : MonoBehaviour
{
    int[] AscendingSort(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = copy.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (copy[j] > copy[j + 1])
                {
                    (copy[j], copy[j + 1]) = (copy[j + 1], copy[j]);
                }
            }
        }
        return copy;
    }
    int[] DescendingSort(params int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        for (int i = copy.Length - 1; i > 0; i--)
        {

            for (int j = 0; j < i; j++)
            {
                if (copy[j] < copy[j + 1])
                {
                    (copy[j], copy[j + 1]) = (copy[j + 1], copy[j]);
                }
            }
        }
        return copy;
    }
    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }
    void Start()
    {
        int[] arr = new int[] { 1, 0, -15, 200, 30, 10 };
        Display(arr);
        Display(AscendingSort(arr));
        Display(DescendingSort(arr));
    }
}