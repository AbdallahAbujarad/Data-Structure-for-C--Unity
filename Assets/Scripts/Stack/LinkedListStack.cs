using UnityEngine;
namespace LinkedListStack
{
    public class LinkedListStack : MonoBehaviour
    {
        void Start()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
            stack.Display();
            stack.Push(100);
            stack.Display();
            stack.Push(300);
            stack.Display();
            stack.Push(200);
            stack.Display();
            Debug.Log(stack.Pop());
            stack.Display();
            Debug.Log(stack.Pop());
            stack.Display();
            Debug.Log(stack.GetTop());
            stack.Display();
        }
    }
    public class Stack<T>
    {
        public class Node
        {
            public T item;
            public Node next;
            public Node(T item)
            {
                this.item = item;
                next = null;
            }
        }
        private Node top = null;
        public void Push(T newItem)
        {
            Node newNode = new Node(newItem);
            newNode.next = top;
            top = newNode;
        }
        bool IsEmpty()
        {
            return top == null;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("Stack Alread Empty");
                return default(T);
            }
            else
            {
                Node tempNode = top;
                top = top.next;
                return tempNode.item;
            }
        }
        public void Display()
        {
            string display = "[ ";
            Node cur = top;
            while (cur != null)
            {
                display += cur.item.ToString() + " ";
                cur = cur.next;
            }
            display += " ]";
            Debug.Log(display);
        }
        public T GetTop()
        {
            return top.item;
        }
    }
}