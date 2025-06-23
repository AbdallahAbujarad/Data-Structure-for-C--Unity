using UnityEngine;

public class LinearSearch : MonoBehaviour
{
    int Search(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
    void Start()
    {
        int[] arr = new int[] { 1, 5, 7, 8, 9 };
        Debug.Log(Search(arr,1));
        Debug.Log(Search(arr,5));
        Debug.Log(Search(arr,7));
        Debug.Log(Search(arr,8));
        Debug.Log(Search(arr,9));
        Debug.Log(Search(arr,10));
    }
}
