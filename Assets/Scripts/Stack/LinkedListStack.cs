using System;
using UnityEngine;
namespace LinkedListStack
{
    public class LinkedListStack : MonoBehaviour
    {
        void Start()
        {
            //Check Stacks
            // Stack<int> stack = new Stack<int>();
            // stack.Pop();
            // stack.Display();
            // stack.Push(100);
            // stack.Display();
            // stack.Push(300);
            // stack.Display();
            // stack.Push(200);
            // stack.Display();
            // Debug.Log(stack.Pop());
            // stack.Display();
            // Debug.Log(stack.Pop());
            // stack.Display();
            // Debug.Log(stack.GetTop());
            // stack.Display();

            //Balanced Parantheses
            Debug.Log(IsBalanced("6()+6+4)"));
            Debug.Log(IsBalanced("{}()[]"));
            Debug.Log(IsBalanced("{(5+3)}"));
        }
        bool isPair(char open, char close)
        {
            return open == '{' && close == '}' || open == '[' && close == ']' || open == '(' && close == ')';
        }
        bool IsBalanced(String exp)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                {
                    s.Push(exp[i]);
                }
                else if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                {
                    if (s.IsEmpty() || !isPair(s.GetTop(), exp[i]))
                    {
                        return false;
                    }
                    else
                    {
                        s.Pop();
                    }
                }
            }
            return s.IsEmpty();
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
        public bool IsEmpty()
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