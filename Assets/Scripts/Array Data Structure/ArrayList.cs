using UnityEngine;
using System.Collections.Generic;
public class ArrayList : MonoBehaviour
{
    public class AR<T>
    {
        T[] arr;
        int maxSize;
        int count;
        public AR(int s)
        {
            if (s < 0)
            {
                maxSize = 10;
            }
            else
            {
                maxSize = s;
            }
            count = 0;
            arr = new T[maxSize];
        }
        bool IsEmpty()
        {
            return count == 0;
        }
        bool IsFull()
        {
            return count == maxSize;
        }
        public int GetSize()
        {
            return count;
        }
        public void Display()
        {
            string display = "";
            for (int i = 0; i < count; i++)
            {
                display += arr[i] + " ";
            }
            Debug.Log(display);
        }
        public void InsertAtPos(int pos, T element)
        {
            if (IsFull())
            {
                Debug.LogWarning("List is Full");
                return;
            }
            if (pos < 0 || pos > count)
            {
                Debug.LogWarning("Out of Range");
                return;
            }

            for (int i = count; i > pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos] = element;
            count++;
        }
        public void RemoveAtPos(int pos)
        {
            if (IsEmpty())
            {
                Debug.LogWarning("List is Empty");
                return;
            }

            if (pos < 0 || pos >= count)
            {
                Debug.LogWarning("Out of Range");
                return;
            }

            for (int i = pos; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            count--;
        }

        public void InsertAtEnd(T element)
        {
            if (IsFull())
            {
                Debug.LogWarning("List is Full");
            }
            else
            {
                arr[count] = element;
                count++;
            }
        }
        public int Search(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(element, arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void InsertNoDuplicate(T element)
        {
            if (Search(element) == -1)
            {
                InsertAtEnd(element);
            }
            else
            {
                Debug.LogWarning("The Element is there ....!");
            }
        }
        public void UpdateAt(int pos, T element)
        {
            if (pos < 0 || pos >= count)
            {
                Debug.LogWarning("Out of Range");
            }
            else
            {
                arr[pos] = element;
            }
        }
        public T GetElement(int pos)
        {
            if (pos < 0 || pos >= count)
            {
                Debug.LogWarning("Out of Range");
                return default(T);
            }
            else
            {
                return arr[pos];
            }
        }
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                arr[i] = default(T);
            }
            count = 0;
        }
    }
    void Start()
    {
        AR<int> list = new AR<int>(5);

        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.Display();  // Output: 10 20 30

        list.InsertAtPos(1, 15);
        list.Display();  // Output: 10 15 20 30

        list.RemoveAtPos(2);
        list.Display();  // Output: 10 15 30

        list.UpdateAt(1, 50);
        list.Display();  // Output: 10 50 30

        Debug.Log("Element at pos 2: " + list.GetElement(2));
        Debug.Log("Index of 50: " + list.Search(50));
    }
}