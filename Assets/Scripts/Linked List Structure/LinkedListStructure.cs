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
                Debug.LogWarning("Out Of Range");
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
                length++;
            }
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
        bool IsEmpty()
        {
            return front == null;
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("List is Empty....");
                return;
            }
            if (length == 1)
            {
                front = null;
                back = null;
                length = 0;
            }
            else
            {
                front = front.next;
                length--;
            }
        }
        public void RemoveEnd()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("List is Empty....");
                return;
            }
            if (length == 1)
            {
                front = null;
                back = null;
                length = 0;
            }
            else
            {
                Node cur = front;
                for (int i = 0; i < length - 2; i++)
                {
                    cur = cur.next;
                }
                back = cur;
                back.next = null;
                length--;
            }
        }
        public void RemoveAtPos(int pos)
        {
            if (IsEmpty())
            {
                Debug.LogWarning("List is Empty....");
                return;
            }
            if (pos < 0 || pos >= length)
            {
                Debug.LogWarning("Out Of Range");
                return;
            }
            if (pos == 0)
            {
                RemoveFirst();
                return;
            }
            if (pos == length - 1)
            {
                RemoveEnd();
                return;
            }
            Node prev = front;
            for (int i = 0; i < pos - 1; i++)
            {
                prev = prev.next;
            }
            Node toDelete = prev.next;
            prev.next = toDelete.next;
            length--;
        }
    }
    void Start()
    {
        LinkedL<int> link = new LinkedL<int>();
        link.InsertFirst(5);
        link.InsertFirst(7);
        link.InsertEnd(6);
        link.InsertAtPosition(1, 1);
        link.Display();
        //7,1,5,6
        Debug.Log("_______________________________");
        for (int i = 0; i < 5; i++)
        {
            link.InsertFirst(Random.Range(0, 10));
        }
        Debug.Log("Current List");
        link.Display();
        Debug.Log("_______________________________");
        link.RemoveEnd();
        link.RemoveFirst();
        link.RemoveAtPos(4);
        link.RemoveAtPos(200);
        link.RemoveAtPos(-1);
        Debug.Log("List After Remove Processes");
        link.Display();
        Debug.Log("_______________________________");
        Debug.Log("Empty List Remove Warnings");
        LinkedL<int> empty = new LinkedL<int>();
        empty.RemoveFirst();
        empty.RemoveEnd();
        empty.RemoveAtPos(0);
    }
}
