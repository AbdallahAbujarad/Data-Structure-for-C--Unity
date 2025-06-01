using UnityEngine;
namespace ArrayStack
{
    public class ArrayStack : MonoBehaviour
    {

        void Start()
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Pop();
            stack1.Display();
            stack1.Push(100);
            stack1.Push(500);
            stack1.Push(1100);
            Debug.Log(stack1.GetTop());
            stack1.Display();
            stack1.Pop();
            Debug.Log(stack1.GetTop());
            stack1.Display();
            int tester = 0;
            stack1.Pop(ref tester);
            stack1.Display();
            Debug.Log(stack1.GetTop());
        }
    }
    public class Stack<T>
    {
        const int max = 100;
        T[] stack;
        public Stack()
        {
            stack = new T[max];
        }
        int top = -1;
        public void Push(T newElement)
        {
            top++;
            stack[top] = newElement;
        }
        bool IsEmpty()
        {
            return top == -1;
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("Stack is Empty");
            }
            else
            {
                stack[top] = default(T);
                top--;
            }
        }
        public void Pop(ref T topItem)
        {
            if (IsEmpty())
            {
                Debug.LogWarning("Stack is Empty");
            }
            else
            {
                topItem = stack[top];
                stack[top] = default(T);
                top--;
                Debug.Log(topItem);
            }
        }
        public void Display()
        {
            string display = "[ ";
            for (int i = top; i >= 0; i--)
            {
                display += stack[i].ToString() + ", ";
            }
            display += "]";
            Debug.Log(display);
        }
        public T GetTop()
        {
            return stack[top];
        }
    }
}
