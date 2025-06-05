using System.Collections.Generic;
using UnityEngine;

public class LinkedListQueue : MonoBehaviour
{
    public class LinkedQueue<T>
    {
        public class Node
        {
            public T item;
            public Node next;
            public Node(T item)
            {
                this.item = item;
            }
        }
        Node front = null;
        Node back = null;
        int length = 0;
        public bool IsEmpty()
        {
            return front == null;
        }
        public void Enqueue(T item)
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                back.next = newNode;
                back = newNode;
            }
            length++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("Its Already Empty");
                return default(T);
            }
            else
            {
                Node temp = front;
                front = front.next;
                length--;
                return temp.item;
            }
        }
        public T GetFront()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("It's Empty");
                return default(T);
            }
            return front.item;
        }
        public T GetBack()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("It's Empty");
                return default(T);
            }
            return back.item;
        }
        public void Display()
        {
            string display = "";
            Node cur = front;
            while (cur != null)
            {
                display += cur.item + " ";
                cur = cur.next;
            }
            Debug.Log(display);
        }
        public void Clear()
        {
            front = null;
            back = null;
            length = 0;
        }
        public int GetSize()
        {
            return length;
        }
    }
    private void Start()
    {
        LinkedQueue<int> queue = new LinkedQueue<int>();
        queue.Display();
        queue.Dequeue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Display();
        Debug.Log(queue.GetFront());
        Debug.Log(queue.GetBack());
        Debug.Log(queue.GetSize());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.GetFront());
        Debug.Log(queue.GetBack());
        Debug.Log(queue.GetSize());
    }
}