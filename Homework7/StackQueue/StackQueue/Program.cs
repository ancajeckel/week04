using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void TestStack()
        {
            Stack myStack = new Stack();
            myStack.Print();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Print();

            int pop = 0;
            pop = myStack.Pop();
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();

            myStack.Push(60);
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();

            pop = myStack.Pop();
            myStack.Print();
        }

        static void TestQueue()
        {
            Queue myQueue = new Queue();
            myQueue.Print();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);
            myQueue.Print();

            int deq = 0;
            deq = myQueue.Dequeue();
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();

            myQueue.Enqueue(60);
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();

            deq = myQueue.Dequeue();
            myQueue.Print();
        }

        static void Main(string[] args)
        {
            TestStack();
            TestQueue();

            Console.ReadKey();
        }
    }
}
