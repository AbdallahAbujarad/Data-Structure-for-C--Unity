using UnityEngine;
public class LinkedListStructure : MonoBehaviour
{
    public class LinkedL<T>
    {
        Node front = null;
        Node back = null;
        int length = 0;
        public class Node
        {
            public T item;
            public Node next;
            public Node(T item)
            {
                this.item = item;
            }
        }
        public void InsertFirst(T item)
        {
            Node newNode = new Node(item);
            if (InsertIfEmpty(newNode)) return;
            newNode.next = front;
            front = newNode;
            length++;
        }
        public void InsertEnd(T item)
        {
            Node newNode = new Node(item);
            if (InsertIfEmpty(newNode)) return;
            back.next = newNode;
            back = back.next;
            back.next = null;
            length++;
        }
        public void InsertAtPosition(T item, int pos)
        {
            Node newNode = new Node(item);
            if (pos < 0 || pos > length)
            {
                Debug.Log("Out Of Range");
                return;
            }
            if (InsertIfEmpty(newNode)) return;
            if (pos == 0) InsertFirst(item);
            else if (pos == length) InsertEnd(item);
            else
            {
                Node cur = front;
                for (int i = 0; i < pos - 1; i++)
                {
                    cur = cur.next;
                }
                newNode.next = cur.next;
                cur.next = newNode;
            }
            length++;

        }
        public void Display()
        {
            Node cur = front;
            for (int i = 0; i < length; i++)
            {
                Debug.Log(cur.item);
                cur = cur.next;
            }
        }
        public T GetFront()
        {
            return front.item;
        }
        public T GetBack()
        {
            return back.item;
        }
        bool InsertIfEmpty(Node newNode)
        {
            if (length == 0)
            {
                front = newNode;
                back = newNode;
                length++;
                return true;
            }
            return false;
        }

    }
    void Start()
    {
        LinkedL<int> link = new LinkedL<int>();
        link.InsertFirst(5);
        link.InsertFirst(7);
        link.InsertEnd(6);
        link.InsertAtPosition(1,1);
        link.Display();
    }
}
