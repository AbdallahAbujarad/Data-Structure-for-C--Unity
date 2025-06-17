using System.Threading;
using Unity.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DoublyLinkedListStructure : MonoBehaviour
{
    public class DLinkedL<T>
    {
        Node front;
        Node back;
        int length = 0;
        public class Node
        {
            public T item;
            public Node prev;
            public Node next;
            public Node(T item)
            {
                this.item = item;
                prev = null;
                next = null;
            }
        }
        public void InsertFirst(T item)
        {
            Node newNode = new Node(item);
            if (length == 0)
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                newNode.next = front;
                front.prev = newNode;
                front = newNode;
            }
            length++;
        }
        public void InsertLast(T item)
        {
            Node newNode = new Node(item);
            if (length == 0)
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                back.next = newNode;
                newNode.prev = back;
                back = newNode;
            }
            length++;
        }
        public void InsertAtPos(int pos, T item)
        {
            if (pos < 0 || pos > length)
            {
                Debug.LogWarning("Out Of Range");
            }
            else if (pos == 0)
            {
                InsertFirst(item);
            }
            else if (pos == length)
            {
                InsertLast(item);
            }
            else
            {
                Node newNode = new Node(item);
                Node cur = front;
                for (int i = 0; i < pos; i++)
                {
                    cur = cur.next;
                }
                newNode.prev = cur.prev;
                cur.prev.next = newNode;
                newNode.next = cur;
                cur.prev = newNode;
                length++;
            }
        }
        public void RemoveFirst()
        {
            if (length == 0)
            {
                Debug.LogWarning("It's Empty....");
            }
            else if (length == 1)
            {
                front = null;
                back = null;
                length--;
            }
            else
            {
                front = front.next;
                length--;
            }
        }
        public void RemoveLast()
        {
            if (length == 0)
            {
                Debug.LogWarning("It's Empty....");
            }
            else if (length == 1)
            {
                front = null;
                back = null;
                length--;
            }
            else
            {
                back = back.prev;
                length--;
            }
        }
        public void RemoveAtPos(int pos)
        {
            if (length == 0)
            {
                Debug.LogWarning("It's Empty....");
            }
            else if (pos < 0 || pos > length - 1)
            {
                Debug.LogWarning("Out Of Range");
            }
            else if (length == 1)
            {
                front = null;
                back = null;
                length--;
            }
            else
            {
                Node toDelete = front;
                for (int i = 0; i < pos; i++)
                {
                    toDelete = toDelete.next;
                }
                toDelete.prev.next = toDelete.next;
                toDelete.next.prev = toDelete.prev;
            }
        }
        public void Display()
        {
            Node cur = front;
            while (cur != null)
            {
                Debug.Log(cur.item);
            }
        }
    }
    void Start()
    {
        DLinkedL<int> link = new DLinkedL<int>();
        link.RemoveAtPos(5);
        link.RemoveFirst();
        link.RemoveLast();
        for (int i = 0; i < 4; i++)
        {
            link.InsertFirst(Random.Range(0, 10));
        }
        link.InsertLast(20);
        link.InsertAtPos(3, 200);
        Debug.Log("Current List");
        link.Display();
        Debug.Log("_________________");
        link.RemoveFirst();
        link.RemoveLast();
        link.RemoveAtPos(2);
        link.RemoveAtPos(-1);
        link.RemoveAtPos(900);
    }
}
