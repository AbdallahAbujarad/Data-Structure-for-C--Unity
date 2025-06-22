using UnityEngine;

public class HeapSort : MonoBehaviour
{
    void Heapify(int[] arr, int i, int size)    // Heapify for max-heap (for ascending sort)
    {
        int max = i;
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        if (left < size && arr[max] < arr[left]) max = left;
        if (right < size && arr[max] < arr[right]) max = right;
        if (max != i)
        {
            (arr[max], arr[i]) = (arr[i], arr[max]);
            Heapify(arr, max, size);
        }
    }
    void HeapifyDes(int[] arr, int i, int size)    // Heapify for min-heap (for descending sort)
    {
        int min = i;
        int left = i * 2 + 1;
        int right = i * 2 + 2;
        if (left < size && arr[min] > arr[left]) min = left;
        if (right < size && arr[min] > arr[right]) min = right;
        if (min != i)
        {
            (arr[min], arr[i]) = (arr[i], arr[min]);
            HeapifyDes(arr, min, size);
        }
    }

    void AscendingSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)        // Build max heap

        {
            Heapify(arr, i, n);
        }
        for (int i = n - 1; i > 0; i--)             // Extract elements from heap
        {
            (arr[i], arr[0]) = (arr[0], arr[i]);
            Heapify(arr, 0, i); // i is the reduced heap size
        }
    }

    void DescendingSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)        // Build min heap
        {
            HeapifyDes(arr, i, n);
        }
        for (int i = n - 1; i > 0; i--)        // Extract elements
        {
            (arr[i], arr[0]) = (arr[0], arr[i]);
            HeapifyDes(arr, 0, i);
        }
    }

    void Display(int[] arr)
    {
        Debug.Log(string.Join(", ", arr));
    }

    void Start()
    {
        int[] arr1 = new int[] { 0, 20, 3, 12, -100 };
        int[] arr2 = new int[] { 0, 20, 3, 12, -100 };
        Debug.Log("ASC");
        AscendingSort(arr1);
        Display(arr1);
        Debug.Log("DES");
        DescendingSort(arr2);
        Display(arr2);
    }
}
