using UnityEngine;
namespace ArrayQueue
{
    public class ArrayQueue : MonoBehaviour
    {
        void Start()
        {
            Queue<int> queue = new Queue<int>();
            queue.Dequeue();
            queue.PrintQueue();
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(9);
            queue.Enqueue(11);
            queue.Enqueue(112);
            queue.Enqueue(70);
            queue.PrintQueue();
            Debug.Log(queue.Dequeue());
            Debug.Log(queue.GetFront());
            Debug.Log(queue.GetBack());
            Debug.Log(queue.Dequeue());
            Debug.Log(queue.Dequeue());
            Debug.Log(queue.Dequeue());
            Debug.Log(queue.Dequeue());
            queue.PrintQueue();

        }
    }
    public class Queue<T>
    {
        int max = 5;
        int front;
        int back;
        T[] queue;
        int count;
        public Queue()
        {
            front = 0;
            back = max - 1;
            count = 0;
            queue = new T[max];
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == max;
        }
        public void Enqueue(T newItem)
        {
            if (IsFull())
            {
                Debug.LogWarning("its Full");
            }
            else
            {
                back = (back + 1) % max;
                queue[back] = newItem;
                count++;
            }
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Debug.LogWarning("its empty");
                return default(T);
            }
            else
            {
                T t = queue[front];
                front = (front + 1) % max;
                count--;
                return t;
            }
        }
        public T GetFront()
        {
            return queue[front];
        }
        public T GetBack()
        {
            return queue[back];
        }
        public void PrintQueue()
        {
            string expression = "[ ";
            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % max;
                expression += queue[index].ToString() + " ";
            }
            expression += "]";
            Debug.Log(expression);
        }
        public void Clear()
        {
            front = 0;
            count = 0;
            back = max - 1;
        }
        public int Count()
        {
            return count;
        }
    }
}